# Contributing

If you use _OpenGL.Net_, and you're willing to improve the project, your contributions are welcome.

## Create an issue

If you find something wrong during the development, you can open an issue to get help. The issue should specify all information that helps to identify the problem. The minimal information to be included should be:

- _OpenGL.Net_ version and configuration;
- Operating system;
- GPU device driver vendor, if correlated with the problem.

The common reasons for creating an issue:

- **Unexpected exceptions**: if you get an unexpected exception from _OpenGL.Net_, the issue should specify the exception stack and message.
- **Missing OpenGL API**: if you expect a GL command, a GL constant or an enumeration, but it is missing or wrong, you can create an issue about it; you can go further by checking the local gl.xml specification, and if it is reasonable, create an issue to the [Khronos GitHub repository](https://github.com/KhronosGroup/OpenGL-API/issues).
- **Toolkit integration**: you can run _OpenGL.Net_ with any toolkit on any(*) platform, just find the display and window handles. You can open an issue for requesting a support library for integrating some toolkit.
- **Missing feature**: you can request any feature implementation, if it is related to the project target.

## Pull request

Once you have created an issue, you are free to submit a pull request relative to the issue.

## Donate

If you like the project, or if it has saved you time, or you just want to offer a free beer to me, you can [![Donate](https://img.shields.io/badge/paypal-me-blue.svg)](http://paypal.me/openglnet).
