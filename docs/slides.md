<!-- .slide: data-background-gradient="linear-gradient(135deg, #0b1220, #172b3f)" -->

# Git & GitHub
### Vom Issue zum Merge

**PR Software Engineering · Team 01**

<small>Live-Demo mit C#/.NET · 16.10.2026</small>

---

## Workflow

**Issue → Branch → Commit → Push → Pull Request → Review → Merge**

- Arbeiten auf `feature/*` statt direkt auf `main`
- Issue-Referenz in Commit/PR dokumentieren
- Mindestens ein Review durch ein anderes Teammitglied

---

## Git CLI · Grundlagen

```bash
git clone https://github.com/OWNER/prse-team01-github-demo.git
cd prse-team01-github-demo
git switch -c feature/hello-world
git status
git add .
git commit -m "Feature: add greeting | refs #1 | time: 30m"
git push -u origin feature/hello-world
```

<small>Git installieren: https://git-scm.com/downloads</small>

---

## Pull Request & Merge

1. Auf GitHub **Compare & pull request** auswählen
2. Issue referenzieren: `Fixes #1` (im PR-Text)
3. Kolleg:in prüft den PR und gibt Review ab
4. Merge nach `main` – nicht direkt auf `main` committen

**CLI zur Synchronisation:**

```bash
git switch main
git pull --ff-only origin main
```

---

## Merge-Konflikt live lösen

Zwei Branches ändern **dieselbe Zeile** in `demo/Program.cs`.

```bash
git switch feature/hello-world
git fetch origin
git merge origin/main
# Konfliktstellen in der IDE auflösen
git add demo/Program.cs
git commit
git push
```

<small>Alternative: Konflikt im Pull Request erkennen und lokal beheben.</small>

---

## GitHub + KI

> „Analysiere Issue #1, schlage einen Feature-Branch vor und bereite die Änderung in `demo/Program.cs` vor. Erkläre mir die Git-Befehle und erstelle keinen Merge ohne Freigabe.“

**Prüfen:** Diff · Tests · Commit · Pull Request · Review

<small>KI-Aktionen hängen von Tool-Zugriff, Rechten und Freigaben ab.</small>

---

# Live-Demo

**C#-Konsole öffnen → Issue → Branch → Commit → PR → Review → Merge**

<small>Fragen?</small>
