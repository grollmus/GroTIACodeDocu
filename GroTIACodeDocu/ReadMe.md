# GroTIACodeDocu

Mit Hilfe von diesem AddIn für TIA Portal V17 können Bibliotheksbausteine ausgelesen und eine anwenderdefinierte Dokumentation für TIA Portal erstellt werden. Mit Hilfe der TIA Openness Schnittstelle wird die Struktur und Kommentare eines Bibliotheksbausteins ausgelesen und in ein Dokumentationsformat gebracht.

## Voraussetzungen
* TIA Portal V17
* zentrale Dokumentationsverzeichnis auf C:\CDoku\UserDocumentation\Library Types vorhanden
* TIA Portal Einstellung Allgemein -> Allgemein -> Anwenderdokumentation -> Zentrales Verzeichnis aktiviert

## Übersetzung
* in VisualStudio Projekt Verweis auf Siemens.Engineering.AddIn.dll erzeugen
* als Postbuildereignis "$(SolutionDir)Publisher\Siemens.Engineering.AddIn.Publisher.exe" -f "$(SolutionDir)$(ProjectName)\Config.xml" -v -c verwenden
* Siemens.Engineering.AddIn.Publisher.exe aus dem SIEMENS Verzeichnis in das Projektverzeichnis kopieren

## Installation
1. GroTIACodeDocu.addIn Datei in das TIA Portal AddIn Verzeichnis kopieren
2. AddIn in TIA Portal aktivieren
3. Sicherheitshinweis bestätitgen

## Bedienung
* In globaler Bibliothek einen Bausteintypen auswählen
* Rechtsklick und GroTIACodeDocu -> Generieren auswählen
* Dialogbox "Es geht gleich los" bestätigen (kann genutzt werden, um sich fürs Debugging an den Prozess zu hängen)
