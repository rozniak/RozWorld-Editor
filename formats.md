#Formats
This file will outline the structure of the RozWorld file formats editable by the RozWorld Editor.

Formats used:
- .bin: Used as GUIOMETRY.BIN, outlines the structure of GUI elements and font information.
- .dat: Used for players where the file is <player-name>.dat, will contain information about player stats, appearance and info as well as inventory and pet data.
- .wld: Used as the key information for a world located in the same folder as the world segments.
- .seg: Used as the world segment (chunk) information carrying tile/entity data.

##.bin (GUIOMETRY.BIN) details
The GUIOMETRY.BIN file format has two major parts to it, the first is simply metadata used for the editor or any other editors to recognise what textures were used. This information is *not* used by RozWorld, since it loads its textures in separately. The first byte of the entire file is the version of the GUIOMETRY.BIN, the rest of the section should have the ID of the texture as a byte, and then followed by a string with the absolute path of the texture.

The IDs of the texture as of version 1 (*still in progress*) are as follows:

| ID  | Texture          |
| --- | ---------------- |
| 1   | Chat Font        |
| 2   | Small Font       |
| 3   | Medium Font      |
| 4   | Huge Font        |
| 5   | Button Body      |
| 6   | Button Top       |
| 7   | Button Side      |
| 8   | Button Edge SW   |
| 9   | Button Edge SE   |
| 10  | TextBox Body     |
| 11  | TextBox Top      |
| 12  | TextBox Side     |
| 13  | TextBox Edge SW  |
| 14  | TextBox Edge SE  |
| 15  | CheckBox Body    |
| 16  | CheckBox Top     |
| 17  | CheckBox Side    |
| 18  | CheckBox Edge SW |
| 19  | CheckBox Edge SE |
| 20  | CheckBox Tick    |

The data in the file should be in this exact order, followed by a 0, to signify the end of the metadata.

Here's what the first section should look like:

| Data                      | Length |
| ------------------------- | ------ |
| Version                   | 1 Byte |
| *Texture Metadata* {      |        |
| Texture ID                | 1 Byte |
| Texture Path              | Varies |
| }                         |        |
| *Repeat for all textures* |        |
| End of Metadata (0)       | 1 Byte |

The second section is the data itself, stored as their individual bytes. The following data after that is split into sections itself; for each of the four font files, there will be the amount of characters included in the font (most likely 2 bytes since Unicode will be supported), and then after that the character and then that character's details.

Here's a representation of what the font subsection looks like:

| Data                        | Length  |
| --------------------------- | ------- |
| Characters in Chat Font     | 2 Bytes |
| *Character* {               | 2 Bytes |
| Blit Origin X               | 2 Bytes |
| Blit Origin Y               | 2 Bytes |
| Blit Destination X          | 2 Bytes |
| Blit Destination Y          | 2 Bytes |
| Before Line                 | 1 Byte  |
| After Line                  | 1 Byte  |
| Y-Offset                    | 1 Byte  |
| }                           |         |
| *Repeat for all characters* |         |
| Chat Font Spacing Width     | 1 Byte  |
| Chat Font Line Height       | 1 Byte  |
| Characters in Small Font    | 2 Bytes |
| *Repeat character block*    |         |
| Small Font Spacing Width    | 1 Byte  |
| Small Font Line Height      | 1 Byte  |
| *etc.etc. for other fonts*  |         |

The next subsection is about the GUI elements (Button, TextBox and CheckBox), each element is composed of different segments, and they have different data. Each element's segments store either, or both, a y-offset or x-offset, and the element overall may have text details.

Here's a representation of the Button and TextBox subsections:

| Data                     | Length  |
| ------------------------ | ------- |
| Element Top Y Offset     | 1 Byte  |
| Element Side X Offset    | 1 Byte  |
| Element Edge SW X Offset | 1 Byte  |
| Element Edge SW Y Offset | 1 Byte  |
| Element Edge SE X Offset | 1 Byte  |
| Element Edge SE Y Offset | 1 Byte  |
| Centred Text             | 1 Byte  |
| Text Offset Top          | 1 Byte  |
| Text Offset Left         | 1 Byte  |


Here's a representation of the CheckBox subsection (it's slightly different):

| Data                     | Length  |
| ------------------------ | ------- |
| Element Top Y Offset     | 1 Byte  |
| Element Side X Offset    | 1 Byte  |
| Element Edge SW X Offset | 1 Byte  |
| Element Edge SW Y Offset | 1 Byte  |
| Element Edge SE X Offset | 1 Byte  |
| Element Edge SE Y Offset | 1 Byte  |


Altogether, the whole file's structure should look like:

| Section          |
| ---------------- |
| Version Byte     |
| Texture Metadata |
| Chat Font Data   |
| Small Font Data  |
| Medium Font Data |
| Huge Font Data   |
| Button Data      |
| TextBox Data     |
| CheckBox Data    |

*The editor is still in development so this file structure might change before version 1 is finished!*


##.dat (Player Data) details
This file format is still being designed.

##.wld (World Information) details
This file format is still being designed.

##.seg (World Segment/Chunk Data) details
This file format is still being designed.
