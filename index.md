
# DocFX Overwrite File Tutorials
Markdown is the format we've chosen to give our customers great documentation in an agile and efficient manner. DocFX overwrite files gives authors and open-source contributors an opportunity to add to, improve upon, or submit changes to API documentation without needing to change the actual source code. This way, we enable our partnes to maintain maintain their own documentation through our "docs as code" strategy, but we also enable CSI to improve upon the generated reference content by adding higher-level conceptual content right in line with the documentation content generated from source code.

This repository contains a sample .NET project and a series of Markdown files. In these files you'll see [YAML](http://yaml.org/) headers. These headers are used by [DocFX](https://dotnet.github.io/docfx/) to enable triple-slash comment (TSC) [overwrites](https://dotnet.github.io/docfx/tutorial/intro_overwrite_files.html). Throughout this repository you'll find numerous ways to use overwrite functionality.

Here is a [short video](https://www.youtube.com/watch?v=wXLBPDi33q4) demonstrating some of the basic functionality of overwrite files. **NOTE**: there is one inaccuracy in the video as of 2016-08-14 - use of the **\*content** moniker is not required to be the last segment in an overwrite file. More on this later.  

## Help Improve Overwriting
There are a few quirks to the overwrite file format writers and contributors will need to know. If you feel any of these quirks are opportunities for improvement, submit an issue to this GitHub repository and we'll triage and try to improve the overwrite file experience. 

## YAML Header

An overwrite file can be separated into any combination of YAML-headed sections. The sections are listed in the [Overwrite files Managed Reference](https://dotnet.github.io/docfx/tutorial/intro_overwrite_files.html#managed-reference-model) section of the DocFX documentation. Each YAML header affects various sections of the generated Managed Reference automatically-generated documentation. 

The following code, for example, would edit the summary of the *IRobotFactory* interface's *AttachRobot* method. *See the [src folder](src) folder for example source code and the [apidoc](apidoc) folder for examples of how to overwrite various sections of the API documentation.

    ---
    uid:RobotFactory.Services.IRobotFactory.AttachRobot
    summary: Contributor-supplied summary since the developer didn't provide one.
    ---

## Remarks
The main purpose of overwrite files is to enable contributions to the **remarks** section of the API documentation. The remarks section is represented by the XML \<remarks\> tag in C# commmentary. It can be tedious to get a good amount of conceptual content with HTML links to other resources and so on in a \<remarks\> section.

    ---
    uid:RobotFactory.Services.IRobotFactory.DetachRobot
    remarks:Use this method **only** when you seriously want to detach the robot and let it go home for the rest of the day. 
    ---

### Using **\*content** in YAML
One line is usually not enough for rich conceptual documentation with images, links to other resources, and examples. The easiest way to provide this rich documentation experience intermingled with the generated source code documentation is to use  **\*content*. 

    ---
    uid:RobotFactory.Services.IRobotFactory.RechargeRobot
    remarks:*content 
    ---
    ## How Recharging Works
    In this way an author has been able to add more rich documentation with multiple sections. The author or contributor could even add images depicting how the particular object's member functions. 

    ![img/recharge-robot.jpg]

### Rules of the Road
1. YAML sections should have a **blank line** between them. 
1. **\*content** 

## Other Resources
1. Refer to [Markdown](http://daringfireball.net/projects/markdown/) for how to write markdown files.
1. [DocFX Overwrites](https://dotnet.github.io/docfx/tutorial/intro_overwrite_files.html)