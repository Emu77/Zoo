🐾 Zooverwaltung – Extended Full Version

Dies ist die erweiterte und vollständige Version der Windows-Forms-Anwendung Zooverwaltung, entwickelt in C# (.NET) mit MySQL-Datenbankanbindung.
Die Anwendung ermöglicht die Verwaltung eines Zoos mit Tierarten, Kontinenten, Gehegen, Tieren – und neu: Futter und Futterrationen pro Tier.
🚀 Funktionen der Anwendung
🐒 Tierverwaltung

    Tiere anlegen, bearbeiten, löschen
    Tierart auswählen
    Gehege auswählen
    Kontinentzugehörigkeit

🌍 Kontinente

    Verwaltung der Kontinente
    Zuordnung von Tierarten

🦁 Tierarten

    Zuordnung zu Kontinenten
    Beschreibung speicherbar

🏞 Gehege

    Gehege anlegen
    Verknüpfung mit Tieren

🥕 NEU: Futterverwaltung

    Futter mit Bezeichnung
    Verpackungsgröße
    Kommentar

🕒 NEU: Futterrationen für Tiere

Jedes Tier kann eine oder mehrere Rationen erhalten:

    Auswahl Futter
    Menge (z. B. „200 g“, „1 Ballen“, …)
    Uhrzeit der Fütterung

🗄 Datenbankmodell (MySQL)
Tabellen:

    Kontinent
    Tierart
    Gehege
    Tier
    Futter
    Futterration

ERD (vereinfacht)

Kontinent 1---* Tierart 1---* Tier 1---* Futterration *---1 Futter

🛠 Technologien
Bereich 	Auswahl
Sprache 	C#
GUI 	Windows Forms
DB 	MySQL
NuGet 	MySql.Data
Architektur 	Repository Pattern
📁 Projektstruktur (vereinfacht)

Zooverwaltung/
│
├── Models/
│   ├── Tier.cs
│   ├── Tierart.cs
│   ├── Gehege.cs
│   ├── Kontinent.cs
│   ├── Futter.cs
│   └── Futterration.cs
│
├── Repositories/
│   ├── TierRepository.cs
│   ├── TierartRepository.cs
│   ├── GehegeRepository.cs
│   ├── KontinentRepository.cs
│   ├── FutterRepository.cs
│   └── FutterrationRepository.cs
│
├── Db.cs
├── Form1.cs
└── Program.cs

⚙️ Installation
Voraussetzungen

    .NET 6 oder neuer
    MySQL 8+
    Visual Studio 2022

NuGet-Paket installieren

MySql.Data

Datenbank einrichten

Führe die bereitgestellte SQL-Datei aus:

CREATE TABLE ...
INSERT INTO ...

▶️ Starten des Programms

    Projekt in Visual Studio öffnen
    NuGet-Paket MySql.Data sicherstellen
    Verbindung in Db.cs anpassen
    Build → Neu erstellen
    Ausführen

📦 ZIP / Downloads

Wenn du möchtest, erstelle ich:

    ✔ eine vollständige ZIP-Version des aktuellen Projekts
    ✔ eine SQL-Datei mit Beispieldaten
    ✔ ein PDF mit ERD + Relationen

Sag einfach „Bitte ZIP erstellen“.
📜 Lizenz

Privates Lernprojekt – freie Nutzung erlaubt.
✉️ Support

Wenn du Bugs hast oder Erweiterungen brauchst:
➡️ Einfach hier im Chat melden.