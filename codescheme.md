#Source code scheme
This document outlines how code in RozWorld and other future repositories should handle code practice. This is a recommended guide and is how design is followed on RozWorld and other projects by me, you may adopt it for your own use, these guides are just what I follow. Code schemes are good to have!

##General Casing

<table>
  <tr>
    <th>Thing</th>
    <th>Casing/Style</th>
    <th>Example</th>
  </tr>

  <tr>
    <td>Local Variables</td>
    <td><code>camelCase</code></td>
    <td>
<code>
public void RepeatString(int amount, string text)<br />
{<br />
&nbsp;&nbsp;&nbsp;&nbsp;string <b>repeatedString</b> = string.Empty;<br />
&nbsp;&nbsp;&nbsp;&nbsp;for (int i = 0; i <= amount; i++)<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>repeatedString</b> += text;<br />
&nbsp;&nbsp;&nbsp;&nbsp;return <b>repeatedString</b>;<br />
}
        </code>
    </td>
  </tr>


  <tr>
    <td>Parameters</td>
    <td><code>camelCase</code></td>
    <td>
<code>
public void RepeatString(int <b>amount</b>, string <b>text</b>)<br />
{<br />
&nbsp;&nbsp;&nbsp;&nbsp;string repeatedString = string.Empty;<br />
&nbsp;&nbsp;&nbsp;&nbsp;for (int i = 0; i <= <b>amount</b>; i++)<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;repeatedString += <b>text</b>;<br />
&nbsp;&nbsp;&nbsp;&nbsp;return repeatedString;<br />
}
</code>
    </td>
  </tr>


  <tr>
    <td>Global Variables, Functions, Classes, Interfaces etc.</td>
    <td><code>PascalCase</code></td>
    <td>
<code>
public abstract class <b>MyInheritableClass</b><br />
{<br />
&nbsp;&nbsp;&nbsp;&nbsp;private string <b>SortOfGlobalString</b>;<br />
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;protected abstract bool <b>MyRequiredFunction</b>();<br />
}<br />
<br />
<br />
public enum <b>MyEnum</b><br />
{<br />
<b>One</b>,<br />
<b>Two</b>,<br />
<b>Three</b><br />
}
</code>
    </td>
  </tr>



  <tr>
    <td>Constants</td>
    <td><code>SCREAMING_CAPS</code></td>
    <td>
<code>
public const string <b>COLOUR_RED</b> = "&4";
</code>
    </td>
  </tr>


  <tr>
    <td>Backing Variables</td>
    <td><code>_UnderscoreBeforePascal</code></td>
    <td>
<code>
private string <b>_BackingVar</b>;<br />
public string BackingVar<br />
{<br />
&nbsp;&nbsp;&nbsp;&nbsp;get { return this.<b>_BackingVar</b>; }<br />
&nbsp;&nbsp;&nbsp;&nbsp;set { this.<b>_BackingVar</b> = value; }<br />
}
</code>
    </td>
  </tr>
</table>

##Whitespace
Whitespace in code is important, never try to squash all your code together, but also never try to spread code out too much. Just try to make it so you can read it when you come to take a look later on.

1. Usings should be grouped by their parent frameworks/APIs, and separated with a single line between different groups, followed by two lines before the main code starts
2. Class global variables and properties should be separated from the main functions with two lines
3. There should be two lines between each different function, for overloads of a single function, use a single line between
4. Variables should be grouped together either by common purpose, or if one is a property and it is grouped with its backing variable, otherwise separate variables/groups with a single line
5. Any line should not be *too long*, the common offender for long lines is if statements, use line breaks where appropriate
6. Separate code blocks with lines between, unless beginning or ending blocks are nested next to each other

##Code Organisation
Namespaces and descriptive/concise names are helpful. If you have a lot of classes that perform network client functions (ie. handling packets, sending/receiving packets), it might be a good idea to stick them in a folder called 'Client', Visual Studio should handle the namespaces automatically unless you rename the folder.

Don't forget Intellisense/XML comments either, make sure you document your functions and possibly variables.

The region blocks can be helpful to minimise code sections to shrink the scrolling requirement. They're there for a reason, so you might as well use them. You might not find them necessary that often since functions and classes can be minimised already, however groups of variables or blocks like if statements cannot so if they're big, stick them in a region.

##Block Comments
Block comments are helpful for segmenting code sections, I use them in some big switch blocks to denote different things being handled for a person scrolling through to easily spot.

They're also good to use in places where you might want to make a large note, or where you might not want an Intellisense comment. The most prominent use of this are the big project headers like those you see on .cs files in RozWorld.

## Line Comments
Line comments should be kept to a line only, short and sweet preferably. Make sure they don't run on too long, not everyone has a 4k monitor so be modest about your line length.