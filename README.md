# CameraWebApi
CameraWebApi 

This api is ASP .net WebApi  which  returns count and Image URL of Cameras

Interface :

	ICameraInfo contains get methods for Add and Retrival.

	This interface is implemented in CameraService and is initialized using Dependency injection.
	For DI I used Autofac.

Service : 

CameraService :  Implements methods inside ICameraInfo interface.


Tests: 

By Using TDD approach i have tested Controller and CameraService with required tests.
For Unit i have used NUnit.

