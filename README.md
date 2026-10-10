# PRSE Team 01 – GitHub Live-Demo

Dieses Repository enthält die Präsentation und eine kleine C#-Konsolenanwendung für die Git-/GitHub-Demonstration von **Team 01** im Praktikum Software Engineering (JKU, WS 2026/27).

Die Präsentation wird mit **Reveal.js** aus einer Markdown-Datei gerendert und über **GitHub Pages** bereitgestellt. Die C#-Anwendung dient als eigenständiges Beispiel für Branches, Commits, Pull Requests und Merge-Konflikte.

## Repository-Struktur

```text
prse-team01-github-demo/
├── .gitignore           # Lokale und generierte Dateien von Git ausschließen
├── README.md            # Dokumentation des Repositories
├── docs/                # Präsentation und GitHub-Pages-Inhalte
│   ├── .nojekyll        # Deaktiviert die Jekyll-Verarbeitung auf GitHub Pages
│   ├── index.html       # Reveal.js-Einstiegspunkt, Theme und Plugins
│   └── slides.md        # Präsentationsfolien in Markdown
└── demo/                # C#-Anwendung für den GitHub-Workflow
    ├── Demo.slnx        # Solutiondatei
    ├── Demo.csproj      # Projektdatei
    └── Program.cs       # Einstiegspunkt der Konsolenanwendung
```

## Präsentation (`docs/`)

- **`slides.md`** enthält die Folien. `---` auf einer eigenen Zeile trennt zwei Folien.
- **`index.html`** lädt Reveal.js, das Markdown-Plugin und die Darstellungseinstellungen.
- **`.nojekyll`** sorgt dafür, dass GitHub Pages die Dateien ohne Jekyll verarbeitet.

### Lokal anzeigen

Im Repository-Verzeichnis einen lokalen Webserver starten:

```bash
python -m http.server 8000 --directory docs
```

Anschließend `http://localhost:8000` öffnen. Die Reveal.js-Bibliotheken werden über ein CDN geladen; dafür ist eine Internetverbindung erforderlich.

## C#-Demo (`demo/`)

Das Verzeichnis enthält eine minimale **.NET-10-Konsolenanwendung**. Sie bildet die Grundlage für die praktische Demonstration von Git-Operationen, Issue-Verknüpfungen, Branches, Pull Requests und Merge-Konflikten.

Voraussetzung: .NET 10 SDK.

```bash
dotnet run --project demo/Demo.csproj
```

## Links

- [Git herunterladen](https://git-scm.com/downloads)
- [Reveal.js – Markdown](https://revealjs.com/markdown/)
- [GitHub Pages](https://docs.github.com/en/pages)
