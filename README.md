# Unicode In WinForms

Use [CompatibleTextRendering](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.label.usecompatibletextrendering?view=netframework-4.8)=false
to avoid issues displaying Unicode characters, see image below.

![](./assets/UseCompatibleTextRenderingFalseToSupportUnicode.png "You'll see this if you run the app")

## But that's too easy if you control the launcher app

Change Main() method in Program.cs to this and you'll run into "Ancient launcher" situation (like [here](https://stackoverflow.com/a/25387037/1175698)):

```csharp
/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
static void Main()
{
	Application.EnableVisualStyles();

	// This is what WinForms app wizard creates today
	//Application.SetCompatibleTextRenderingDefault(false);

	// This is what you may expect if running in "old container"
	Application.SetCompatibleTextRenderingDefault(true);

	Application.Run(new Form1());
}
```
.. and Unicode chars are not displayed anymore. How to solve this problem? I don't know yet...
