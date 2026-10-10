# PRSE Team 01 – GitHub Live-Demo

## Empfehlung: Zwei Repositories

1. **Offizielles PRSE-Team-Repository:** Java/JavaFX-Semesterprojekt, gemeinsame Issues und Releases. Namensvergabe und Zugriffsrechte mit der LV-Leitung abstimmen.
2. **`prse-team01-github-demo`:** Präsentation und isolierte C#-Demo für den Termin am **16.10.2026**. Keine Übungscommits im Semesterprojekt.

Das Vorjahresbeispiel ist [`jku-win-se/teaching-2026.ss.prse.braeuer.team4`](https://github.com/jku-win-se/teaching-2026.ss.prse.braeuer.team4). Daraus folgt **nicht automatisch**, dass ein neues Repo in dieser Organisation angelegt werden darf.

## Projektstruktur

```text
prse-team01-github-demo/
├── README.md
├── docs/
│   ├── index.html       # Reveal.js-Startseite (nur technische Hülle)
│   ├── slides.md        # ALLE Präsentationsinhalte hier bearbeiten
│   └── .nojekyll
└── demo/
    ├── Demo.csproj      # Minimales C#/.NET-Beispiel
    └── Program.cs
```

## GitHub Pages einrichten

1. Neues **öffentliches** Repository `prse-team01-github-demo` anlegen (GitHub Pages auf GitHub Free für öffentliche Repositories).
2. Diese Dateien in den `main`-Branch pushen.
3. **Settings → Pages → Build and deployment → Deploy from a branch** wählen.
4. Branch **`main`**, Folder **`/docs`**, dann **Save**.
5. Die URL lautet gewöhnlich `https://USERNAME.github.io/prse-team01-github-demo/` (bei Organisations-Repo entsprechend `ORG.github.io`).

**Wichtig:** GitHub Pages veröffentlicht nur `docs/`. Änderungen im Ordner `demo/` sind vom Präsentationsinhalt getrennt. Pages-Builds können dennoch bei Pushes auf `main` ausgelöst werden; die Website bleibt durch die getrennten Inhalte stabil.

## Präsentation bearbeiten

Nur `docs/slides.md` ändern. Jede Zeile `---` trennt eine Folie. `docs/index.html` lädt Reveal.js und das Markdown-Plugin von CDN. Für lokale Vorschau einen HTTP-Server verwenden (direktes Öffnen per `file://` kann wegen Markdown-Fetch blockiert werden):

```bash
python -m http.server 8000 -d docs
```

Dann `http://localhost:8000` öffnen. Internetzugang ist für die Reveal.js-CDN-Dateien nötig.

## C#-Demo starten

.NET 10 SDK installieren, dann:

```bash
dotnet run --project demo/Demo.csproj
```

## Ablauf am 16.10.2026

1. Im **Demo-Repo** ein Issue erstellen, z. B. `#1 Begrüßung erweitern`.
2. Repo klonen und `git switch -c feature/greeting` ausführen.
3. `demo/Program.cs` ändern, `git add`, `git commit -m "Feature: extend greeting | refs #1 | time: 30m"`, `git push -u origin feature/greeting`.
4. GitHub Pull Request öffnen, im PR-Text `Fixes #1` verlinken und Team-Review durchführen.
5. Konflikt mit zwei Änderungen an derselben Codezeile vorbereiten und lokal auflösen; PR erst danach mergen.
6. Optional KI zeigen: natürliche Sprache → Vorschlag für Änderungen und Git-Befehle; Diff und Berechtigungen kontrollieren.

**Hinweis zur Aufgabenverteilung:** Für Team 01 sind Git-Workflows und KI gefragt. Der `time: 30m`-Tag ist ein Beispiel der separaten Time-Tracking-Vorgabe aus der LV (Team 02/05). Im eigentlichen Semesterprojekt gelten die Vorgaben der Lehrveranstaltung, insbesondere Java/JavaFX und Review-Workflow.

## Links

- [Git herunterladen](https://git-scm.com/downloads)
- [Reveal.js Dokumentation](https://revealjs.com/markdown/)
- [GitHub Pages Dokumentation](https://docs.github.com/en/pages)
