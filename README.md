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

4. Add Converter Resources to App.xaml
				
	4.1. Open App.xaml in your main project.

	4.2. Inside the <Application.Resources> section, merge the converter resource dictionaries from the library:
		
		<Application.Resources>
			<ResourceDictionary>
				<ResourceDictionary.MergedDictionaries>
					<ResourceDictionary Source="/WPF.Converters;component/ValueConverters/ValueConverters.xaml"/>
					<ResourceDictionary Source="/WPF.Converters;component/MultiValueConverters/MultiValueConverters.xaml"/>
				</ResourceDictionary.MergedDictionaries>
			</ResourceDictionary>			
		</Application.Resources>

	4.3. All the value converters from the library are now available throughout your application.

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
	- InverseVisibilityConverter	=>	Flips a Visibility value. Visible becomes Collapsed; Collapsed/Hidden becomes Visible.

	- StringToUpperConverter	=>	Transforms the string to uppercase.
	- StringToLowerConverter	=>	Transforms the string to lowercase.
	- TypeToStringConverter	=>	Converts an object instance into its Type Name as a string.

	### MultiValueConverters
	- AndBooleanToBooleanMultiConverter	=>	Returns true only if all bindings are true.
	- AndBooleanToInverseBooleanMultiConverter	=>	Returns false only if all input values are true.
	- OrBooleanToBooleanMultiConverter	=>	Returns true if any of the input values are boolean true.
	- OrBooleanToInverseBooleanMultiConverter	=> Returns false if at least one input value is true.

	- AndBooleanToVisibilityMultiConverter	=>	Returns Visible only if all input values are true.
	- AndBooleanToInverseVisibilityMultiConverter	=>	Returns Visible if any input value is false, null, or unset.

# License
MIT License

Copyright (c) 2026 MICHAEL SAMULA

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
