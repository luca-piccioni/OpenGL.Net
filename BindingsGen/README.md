# BindingsGen — maintainer guide

Purpose
- `BindingsGen` is the generator used to produce the managed Khronos API bindings and support files included in this repository (OpenGL.Net, OpenWF.Net, OpenVX.Net, ...). It consumes Khronos XML specs and headers, optional RefPages HTML man pages, and a set of local mapping files to emit strongly-typed enums, command implementations, extension support, limits, version constants and other helper files.

Where to look
- Entry point: `BindingsGen/Program.cs` — parses command-line options and orchestrates generation.
- Core processor: `BindingsGen/RegistryProcessor.cs` — contains the code generation logic (files produced, file naming, per-feature splitting, VB compatibility, log map generation, delegates, limits, versions, etc.).
- Specification parsing / context: `BindingsGen/RegistryContext.cs` — wraps the XML registry and words/extension dictionaries, holds `RefPages` handlers.
- Assembly stripping: `BindingsGen/RegistryAssembly.cs` and `BindingsGen/RegistryAssemblyConfiguration.cs` — use `Mono.Cecil` to produce trimmed assemblies for specific profiles.
- IO helper: `BindingsGen/SourceStreamWriter.cs` — writer used for consistent indentation and optional dry-run (`--dummy`).
- GL/other spec models & helpers: `BindingsGen/GLSpecs/*.cs` and `BindingsGen/GLSpecs/*.xml` (e.g. `CsTypeMap.xml`, `CommandFlags.xml`, `ExtWords.xml`, words maps for Gl/Egl/Glx/Wgl/VX etc.).
- Embedded resources: `BindingsGen/Licenses/MIT.txt` is used for file preambles.

Build & runtime requirements
- `BindingsGen` is a .NET Framework tool (target `net48` in `BindingsGen.csproj`) and depends on the `Mono.Cecil` NuGet package.
- Typical build/run environment on this project: Windows with Visual Studio 2022 (the repository vertical tasks call `vcvars64.bat` then MSBuild).
- On CI/headless machines: ensure MSBuild / .NET Framework 4.8 and `vcvars` environment or adapt the build task; `BindingsGen` will not build on `dotnet`-only SDKs because it targets `net48`.

How to regenerate the APIs (recommended)
- Use the provided VS Code tasks (recommended):
  1. `Restore` — runs `dotnet restore OpenGL.Net.sln`.
  2. `Build` (or `MSBuild (VS 2022)`) — builds the whole solution including `BindingsGen.exe`.
  3. `Generate APIs` — runs `${workspaceFolder}/BindingsGen/bin/Release/BindingsGen.exe` with the working directory set to `BindingsGen/bin/Release/` so relative paths match `Program.BasePath` expectations.

Manual CLI examples (PowerShell on Windows)
- Default generation (GL, WGL, GLX, EGL, VX, OpenWF variants as enabled in `Program`):
  - From `BindingsGen/bin/Release/` run: `.
BindingsGen.exe` (the generator's `BasePath` is set so it finds `../../..` resources).
- Generate only GL sources: `.
BindingsGen.exe --gl`
- Generate only log map XMLs (no C#): `.
BindingsGen.exe --only-logmaps`
- Dry-run (no file writes): `.
BindingsGen.exe --dummy`
- Disable scanning of RefPages (skip HTML man page parsing): `.
BindingsGen.exe --nodoc`

Profile and assembly stripping
- `--assembly <path>` instructs the tool to run the assembly cleaning mode. This uses `RegistryAssembly` together with configuration(s) loaded from embedded profile resources: `BindingsGen.Profiles.CoreProfile.xml`, `BindingsGen.Profiles.ES2Profile.xml`, `BindingsGen.Profiles.SC2Profile.xml`.
- The `--assembly-overwrite` switch (or `--assembly-overwrite*`) will overwrite the input file. If not provided a new assembly is written with a suffix (see `RegistryAssembly.CleanAssembly`).
- `RegistryAssembly` uses `Mono.Cecil` to remove enum fields, constants, methods and delegates that are not compatible with the selected profile(s). Maintain or extend the XML profile resources in `BindingsGen/Profiles/` (these are embedded resources referenced by `RegistryAssemblyConfiguration.Load`).

Command-line switches (important ones)
- `--gl`, `--wgl`, `--glx`, `--egl`, `--vx` — choose which API family to generate. When none are present, the generator enables sensible defaults (most APIs).
- `--gl-commands`, `--gl-extensions`, `--gl-limits` — in combination with `--gl` restrict GL generation to specific parts (this disables default feature generation and only generates the selected subset).
- `--wfc`, `--wfd` — generate OpenWF C / D bindings from headers (requires the CLI/header flow used in `Program`).
- `--assembly --assembly-overwrite` — assembly stripping mode.
- `--only-logmaps` — only write the Khronos log maps (XML describing commands and enum-typed params) to `OpenGL.Net/KhronosLogMap*.xml`.
- `--dummy` — suppress actual writing from `SourceStreamWriter` (useful to check console logs without emitting files).
- `--nodoc` — skip RefPages scanning (useful if RefPages are missing or to speed up runs).
- `--profile-core`, `--profile-es2`, `--profile-sc2` — when used with `--assembly` restrict assembly processing to those specific profiles.

Input sources
- Khronos XML specs: `GLSpecs/gl.xml`, `GLSpecs/egl.xml`, `GLSpecs/wgl.xml`, `GLSpecs/glx.xml`, plus `VXSpecs` and `WF` headers. These are parsed into `BindingsGen.GLSpecs.Registry` via `XmlSerializer`.
- Header parsing: small helper `Header` class (in `GLSpecs/Header.cs`) can append C headers for non-XML specifications (used for Wf/Wfd/Wfc and VX headers in `Program`).
- Reference pages: HTML manpages in `RefPages/` are scanned by `RegistryDocumentation`/`RegistryDocumentationHandler*` implementations to extract function/enum documentation used to emit XML doc comments.
- Words & mapping files: `BindingsGen/GLSpecs/*.xml` files provide name simplification and C# type mappings (e.g. `CsTypeMap.xml`, `GlWords.xml`, `ExtWords.xml`, `EglWords.xml`, `GlTokensMap.xml`). Edit these to refine generated identifier names or C# type mapping.

Output: naming & file layout
- Output base (default): `OpenGL.Net` (configurable via `Program.OutputBasePath`).
- Common generated files:
  - `OpenGL.Net/Gl.Enums.cs` — strongly-typed enums for the registry.
  - `OpenGL.Net/Gl.*.cs` (one per feature) — commands and enums split per feature; extensions are placed in subfolders (e.g. `OpenGL.Net/EXT/Gl.EXT_texture* .cs`).
  - `OpenGL.Net/Gl.Orphans.cs` — commands/enums not attached to a feature.
  - `OpenGL.Net/Gl.Extensions.cs` — boolean fields indicating extension support (class `Extensions`).
  - `OpenGL.Net/Gl.Limits.cs`, `Gl.Versions.cs` — limit and versions helpers.
  - `OpenGL.Net/Gl.Vb.cs` — VB-compatible alternative function names when conflicts are detected.
  - `OpenGL.Net/KhronosLogMapGl.xml` (and Wgl/Glx/Egl) — generated log maps used by Khronos logging utilities.
- Generated partial classes follow the existing convention: `public partial class Gl { ... }` and are intended to be authoritative (see warning below).

Customization points & where to change behaviour
- Change name/type mapping: `GLSpecs/CsTypeMap.xml` and `GLSpecs/TypeMap.cs`/`Type.cs`.
- Command filtering / feature flags: update `GLSpecs/CommandFlags.xml` and `CommandFlagsDatabase.cs` to mark special cases (disabled commands, excluded limits, extra limits, VB incompatibilities, etc.).
- Words and abbreviation rules: update the words maps `GLSpecs/*Words.xml` and `SpecWordsDictionary.cs`.
- Documentation parsing: `RegistryDocumentationHandler*.cs` implement page parsing rules for GL4/GL2/EGL; extend or fix these to improve XML doc extraction.
- File layout/naming: `RegistryProcessor.GetFeatureFilePath` determines placement of feature files and per-extension directories.
- If you need to change how the registry is parsed, look at `GLSpecs/Registry.cs` (XML-serialized model). The serializer is configured in `RegistryContext` (`_SpecSerializer`).

Best practices & gotchas
- Never hand-edit generated files that contain the string `This file is automatically generated`. Instead, either:
  - Adjust the generator (`BindingsGen`) logic (preferred), or
  - Update the source specification (`GLSpecs/gl.xml` / `GLSpecs/*` / `RefPages/*`).
- `BindingsGen` embeds license text into produced files from `BindingsGen/Licenses/MIT.txt` — keep the header in generated outputs.
- RefPages: some documentation handlers expect local copies of DTDs in `RefPages/DTD`. Missing DTDs or missing `RefPages` content can cause the documentation scan to fail — use `--nodoc` to skip scanning if necessary.
- The generator targets `net48`. Building the tool requires Visual Studio/MSBuild or an environment able to compile `net48` projects. The repository's VS Code tasks call `vcvars64.bat` and `MSBuild.exe`.
- Use `--dummy` to perform dry runs during development to avoid churn in the generated tree while verifying logic.

Troubleshooting
- "XmlSerializer.UnknownElement" messages: check `BindingsGen/GLSpecs/Registry.cs` and the XML spec version; the serializer reports unknown elements encountered during parsing.
- Generated identifiers conflict / unexpected names: update word maps (`*Words.xml`) or `SpecificationStyle` helpers in the generator.
- Assembly stripping removed too much/too little: inspect `BindingsGen/Profiles/*.xml` and `RegistryAssembly.IsCompatible*` logic; add explicit `RequiredByFeatureAttribute`/`RemovedByFeatureAttribute` logic adjustments if needed.

Notes for maintainers
- Tests & samples in repository may depend on how the runtime binds to native APIs — keep track of `PlatformTarget`, `Prefer32Bit` in sample projects.
- When adding a new Khronos spec: add the XML/header files to `GLSpecs/` or `VXSpecs/` and feed `RegistryContext` appropriately (see examples for VX/WF in `Program.cs`).
- To add a new profile for assembly-stripping, add a new `BindingsGen.Profiles.*.xml` resource and reference it in `Program.cs` or call it via `--assembly`.

License
- `BindingsGen` and generated headers include the MIT license text found in `BindingsGen/Licenses/MIT.txt`. The generator sources themselves are GPL-licensed (see top-of-file headers).

Contact
- See project repository and AUTHORS for maintainers.

## How enumerations and commands are generated (implementation details)

This section documents the generator internals so maintainers can reason about why specific code is emitted and where to change behavior.

### Enumerations (see `GLSpecs/EnumerantGroup.cs`)

- Groups and bitmasks: the generator collects `EnumerantGroup` definitions from the parsed registry and determines whether the group represents a bitmask by inspecting the parent `EnumerantBlock` (type "bitmask"). If any member belongs to a bitmask block the produced enum is annotated with `[Flags]` and uses an unsigned backend (`uint`) when needed.

- Value-based grouping and uniqueness: enumerants in a group are collected by their numeric value so different names that map to the same value are grouped together. The code then reduces duplicates and selects a canonical set of names to emit. This avoids emitting duplicated enum members coming from vendor variants (e.g. `_ARB`, `_EXT`).

- Backend type selection: the enum underlying type is selected depending on whether the group is a bitmask. By default enums use `int`; bitmask groups use `uint`.

- Name transformations and per-group tweaks: implementation names are converted to C#-friendly camelCase via `SpecificationStyle.GetCamelCase`. The `CommandFlagsDatabase` may override group behavior (prefix trimming, additional enumerants, forced type) through its configuration.

- Feature attributes: when emitting each enum member the generator writes `RequiredByFeature` and `RemovedByFeature` attributes derived from the registry linkage. These attributes are used later by `RegistryAssembly` to strip symbols for specific profiles.

- Documentation: short XML doc comments are emitted for each enum and member. If RefPages are available the generator may use extracted documentation to improve emitted comments.

### Commands (see `GLSpecs/Command.cs` and `RegistryProcessor.cs`)

Overall flow
- `RegistryProcessor.GenerateCommandsAndEnums` collects commands per feature and orphaned commands and calls `Command.GenerateImplementations` for each command. Delegates are generated by `RegistryProcessor.GenerateCommandsDelegates` (it emits an internal `Delegates` nested class and calls `Command.GenerateDelegate` for each command).

Overloads and compatibility variants
- For each command the generator computes a set of overload parameter lists via `Command.GetOverridenImplementations`. The decision tree checks a number of compatibility predicates such as:
  - `CommandParameterStrong.IsCompatible` — whether some parameters can be represented with strongly-typed managed structs/objects (strong variants).
  - `CommandParameterPinned.IsCompatible` — whether parameters can be marshalled by pinning managed objects.
  - `CommandParameterArrayLength.IsCompatible` — array+length correlated parameters that can be represented as arrays instead of raw pointer/length pairs.
  - `CommandParameterUnsafe.IsCompatible` and command flags like `CommandFlags.UnsafeParams` — to emit unsafe pointer-based signatures.
  - `CommandFlags.OutParamLast` and out-parameter handling to emit `out` variants.
- Based on those checks the generator emits one or more overloads: plain/default, strongly-typed, pinned-object, out-parameter, array-length and unsafe variants. The algorithm ensures a plain wrapper exists in cases where interaction between overrides could otherwise create recursion/stack overflow.

Signature generation
- `Command.GenerateImplementation_Signature` writes the method signature including:
  - visibility (from `CommandFlagsDatabase.GetCommandVisibility`), `static`, and optional `unsafe` modifier (computed by `IsUnsafeImplementationSignature`).
  - return type (computed by `GetImplementationReturnType`) and method name (with extension-derived naming when needed).
  - parameters: attributes, modifiers and types are emitted using helpers on `CommandParameter` (`GetImplementationTypeAttributes`, `GetImplementationTypeModifier`, `GetImplementationType`). Implicit parameters are skipped; `params` is emitted for final variadic managed arrays.
  - generic constraints when applicable.
- Documentation and attributes: if `RefPages` are present the generator emits XML documentation for the method. It also writes `[RequiredByFeature]` and `[RemovedByFeature]` attributes for the method based on its feature linkage.

Delegate generation and invocation
- For each command a native function delegate type and a `Delegates` static field are emitted. `Command.GenerateDelegate` builds the delegate signature mapping C return types to appropriate C# types (some backend-specific return types such as `Gl.Enum` are translated to `IntPtr` for delegates where necessary).
- The implementation body calls `Debug.Assert(Delegates.p<Command>() != null, "<name> not implemented")` and invokes the delegate through the `Delegates` field. Parameters are marshalled appropriately for the chosen overload.

Marshalling variants
- Default/fixed implementations use `fixed` blocks when required (strings/arrays/pointers) — this is decided by `IsFixedImplementation`/`IsSafeMarshalImplementation`.
- Pinned-object variants wrap managed objects in pinned blocks and pass pointers to the delegate; corresponding `GenerateImplementation_Pinned` emits the pinning scope and parameter marshalling.
- Unsafe variants emit `unsafe` signatures and pass pointer types directly.

Logging, error checking and return handling
- After calling the native delegate the generator emits optional call-logging code (used by Khronos log map facilities) and optionally checks the error state via `GetError` unless the command is flagged `NoGetError`.
- Return values are stored in a local variable with the delegate return type (`DelegateReturnType`) and are translated to the public return type when necessary.

VB support
- When there are naming conflicts that would be problematic in VB.Net the generator emits a nested `VB` utility class containing alternative names (see `RegistryProcessor.GenerateVbCommands`). The generator also outputs `VBEnum` for enum names that conflict with methods.

Practical maintenance notes
- If you need to change how parameter variants are emitted, update the compatibility check helpers in `GLSpecs` (e.g. `CommandParameterStrong`, `CommandParameterPinned`, `CommandParameterArrayLength`, `CommandParameterUnsafe`) and the per-parameter helper methods on `CommandParameter` that determine attribute/modifier/type strings.
- To alter how delegates are produced (calling conventions, return type translations), edit `Command.GenerateDelegate` and `Command.DelegateReturnType`.
- To tune which overloads are generated for a command, adjust the logic in `Command.GetOverridenImplementations` which composes the list of overload parameter sets.
