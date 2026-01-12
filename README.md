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

	### ValueConverters
	- InverseBoolConverter	=>	Flips true to false and vice versa.
	- StringNullOrEmptyToBooleanConverter	=>	Returns true if the string is null or empty; otherwise, false.
	- StringNullOrEmptyToInverseBooleanConverter	=>	Returns true if the string has content; returns false if the string is null or empty.
	- StringNullOrWhiteSpaceToBooleanConverter	=>	Returns true if the string is null, empty, or consists only of white-space characters; otherwise, false.
	- StringNullOrWhiteSpaceToInverseBooleanConverter	=>	Returns true only if the string contains actual non-whitespace characters.
	- NullToBooleanConverter	=>	Returns true if the value is null; otherwise, false.
	- NullToInverseBooleanConverter	=>	Returns true if the object is not null; returns false if the object is null.
	- CollectionEmptyToBooleanConverter	=>	Evaluates a collection and returns true if it is empty.
	- CollectionEmptyToInverseBooleanConverter	=>	Evaluates a collection and returns true if it contains at least one item.

	- NullToVisibilityConverter	=>	Returns Visible if the value is null; Collapsed if the value has an object.
	- NullToInverseVisibilityConverter	=>	Returns Collapsed if the value is null; Visible if the value has an object.
	- CollectionEmptyToVisibilityConverter	=>	Evaluates a collection and returns Visibility.Visible if it is empty.
	- CollectionEmptyToInverseVisibilityConverter	=>	Evaluates a collection and returns Visibility.Visible if it contains items.

	### MultiValueConverters
	- AndBooleanToBooleanMultiConverter	=>	Returns true only if all bindings are true.
	- AndBooleanToInverseBooleanMultiConverter	=>	Returns false only if all input values are true.
	- OrBooleanToBooleanMultiConverter	=>	Returns true if any of the input values are boolean true.
	- OrBooleanToInverseBooleanMultiConverter	=> Returns false if at least one input value is true.

# License
Distributed under the MIT License. See LICENSE for more information.
