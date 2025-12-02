ARG VARIANT=8.0-jammy
FROM mcr.microsoft.com/devcontainers/dotnet:${VARIANT}

# Install Mono for .NET Framework support
RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
    && apt-get -y install --no-install-recommends mono-complete \
    && apt-get clean -y && rm -rf /var/lib/apt/lists/*
