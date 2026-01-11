# Wpf.Converters
A collection of IValueConverter and IMultiValueConverter implementations to simplify data binding in WPF applications.

# Installation (Git Submodule)

Since this library is not yet on NuGet, the recommended way to use it is as a Git submodule. 
This allows you to keep the library updated while keeping it inside your own repository.

1. Add the Submodule
Open your terminal in your main project's root folder and run:

		git submodule add https://github.com/msamula/WPF.Converters.git Libs/Wpf.Converters

2. Add to your Solution

	2.1. Open your project in Visual Studio.

	2.2. Right-click on your Solution > Add > Existing Project...

	2.3. Navigate to Libs/Wpf.Converters and select the .csproj file.

3. Add Project Reference

	3.1. In your Main UI Project, right-click Dependencies (or References).

	3.2. Select Add Project Reference.

	3.3. Check the box for Wpf.Converters.

# Updating the Submodule

If you have added this library as a git submodule, run the following command inside the submodule's directory in your terminal:

	git pull origin master

# Available Converters

	- ValueConverters
	InverseBoolConverter	=>	Flips true to false and vice versa.

	- MultiValueConverters
	AndBooleanToBooleanMultiConverter	=>	Returns true only if all bindings are true.

# License
Distributed under the MIT License. See LICENSE for more information.
