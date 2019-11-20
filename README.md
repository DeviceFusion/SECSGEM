# SECSGEM

This is a sample from a project that enhanced an existing piece of equipment with a SECS/GEM interface so that it could be interfaced for machine to machine control.  SECS/GEM is the semiconductor’s equipment interface protocol for equipment-to-host data communications. In an automated semi-conductor fabrication facility, the interface can start and stop equipment processing, collect measurement data, change variables and select recipes for products. The SECS (SEMI Equipment Communications Standard)/GEM (Generic Equipment Model) standards do all this in a defined way.

This sample was added because SECS/GEM it is the factory automation equivalent of BACnet in building automation. There are however some key differences in the specifications. The greatest being that BACNET defines all possible device types, objects, properties, and services and any BACNET device has to be modeled in terms of these fixed definitions. SECS/GEM is more open in that equipment is characterized in terms of general mechanisms of data variables, data constants, events and alarms and the specifics of what those entities are can be defined as anything for a given piece of equipment.

The development project was for a customer and is proprietary so no code samples are provided. The two files provided are a snippet of a design document that was used as a working specification to define how the existing equipment would be characterized for SECS/GEM and then a snippet of a configuration file that formally defines the equipment for the CIMConnect SECS/GEM software library. This formal definition is based on the design document.  Again all of this conceptually equivalent to working with BACnet devices. 

Files: 
SECS_GEM dictionary specification.docx – design specification snippet
CIMConnect.txt – SEC/GEM equipment definition snippet for CIMConnect

