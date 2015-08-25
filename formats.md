#Formats
This file will outline the structure of the RozWorld file formats editable by the RozWorld Editor.

Formats used:
- .bin: Used as GUIOMETRY.BIN, outlines the structure of GUI elements and font information.
- .dat: Used for players where the file is <player-name>.dat, will contain information about player stats, appearance and info as well as inventory and pet data.
- .wld: Used as the key information for a world located in the same folder as the world segments.
- .seg: Used as the world segment (chunk) information carrying tile/entity data.

##.bin (GUIOMETRY.BIN) details
The GUIOMETRY.BIN file format has two major parts to it, the first is simply metadata used for the editor or any other editors to recognise what textures were used. This information is *not* used by RozWorld, since it loads its textures in separately.

The second section is the data itself, stored as their individual bytes. The first byte should represent the version of the GUIOMETRY.BIN file, since it may have revisions in future, and thus the bytes representing different things.

The following data after that is split into sections itself, for each of the four font files, there will be the amount of characters included in the font (most likely 2 bytes since Unicode will be supported), and then after that the character and then that character's details. Here's a representation of what it looks like:

[VERSION] (1 byte)
[CHARACTERS IN CHAT FONT] (2 bytes)
---
[CHARACTER] (2 bytes)
[BLIT ORIGIN X] (1 byte)
[BLIT ORIGIN Y] (1 byte)
[BLIT DESTINATION X] (1 byte)
[BLIT DESTINATION Y] (1 byte)
[BEFORE LINE] (1 byte)
[AFTER LINE] (1 byte)
[Y OFFSET] (1 byte)
--- *repeat this block for the amount of characters specified in the font*
[CHARACTERS IN SMALL FONT] (2 bytes)
 -*etc etc. for small font, medium font and huge font


##.dat (Player Data) details
This file format is still being designed.

##.wld (World Information) details
This file format is still being designed.

##.seg (World Segment/Chunk Data) details
This file format is still being designed.
