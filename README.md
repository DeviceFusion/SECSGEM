# SECSGEM

This is a sample from a project that enhanced an existing piece of equipment with a SECS/GEM interface so that it could be enabled for machine to machine control.  SECS/GEM is the semiconductor’s equipment interface protocol for equipment-to-host data communications. In an automated semi-conductor fabrication facility, the interface can start and stop equipment processing, collect measurement data, change variables and select recipes for products. The SECS (SEMI Equipment Communications Standard)/GEM (Generic Equipment Model) standards do all this in a defined way.

In SECS/GEM equipment is characterized in terms of general mechanisms of data variables, data constants, events and alarms and the specifics of what those entities are can be defined as anything for a given piece of equipment.

The development project was for a customer and is proprietary so no code samples are provided. The two files provided are a snippet of a design document that was used as a working specification to define how the existing equipment would be characterized for SECS/GEM and then a snippet of a configuration file that formally defines the equipment for the CIMConnect SECS/GEM software library. This formal definition is based on the design document.

Files: 
SECS_GEM dictionary specification.docx – design specification snippet
CIMConnect.txt – SEC/GEM equipment definition snippet for CIMConnect
SecGemUI.Designer.vb - User Interface example for the machine's Human Interface as layed out in Visual Studio
SecGemUI.resx - Associated VB resource file
SecsGemUI.vb - VB Code examle for application specific UI event handlers and associated code
