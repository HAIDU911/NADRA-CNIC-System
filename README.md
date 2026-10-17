# NADRA CNIC Management System

A full-screen desktop application built with **VB.NET (Windows Forms, .NET Framework 4.8)** for
**Assignment # 2 – Question 1 (CLO-2)** of *Visual Programming* (BSE 5A & 5B, Software Engineering Department).

The application reproduces the look and workflow of a NADRA (National Database & Registration Authority)
citizen-registration counter: officer sign-in, citizen records in a Microsoft Access database, CNIC
validation and check-digit verification, identity-card printing, reports and an **OpenCV** visual-effects
module driven by the webcam.

---

## Assignment requirements → implementation

| Requirement | Where it is implemented |
|---|---|
| .NET application | VB.NET / WinForms, `.NET Framework 4.8`, solution `NADRA_CNIC_System/NADRA_CNIC.sln` |
| NADRA database | Microsoft Access (`.mdb`) through `Microsoft.Jet.OLEDB.4.0`; tables `Officers`, `Citizens`, `ActivityLog` created automatically on first run |
| Maximum Toolbox controls used | see the control inventory below (50+ distinct controls) |
| OpenCV module with a visual effect | `frmVisual` – live webcam, 8 real-time effects, Haar-cascade face detection, snapshot save |
| Adding requirements (own features) | check-digit verification, verification workflow, photo capture, card printing, charts, backups, integrity check, audit log, full-screen mode |

## Features

**Officer / security**
- Login form with NADRA branding, password masking, "show password", remember user name.
- Passwords stored as salted SHA-256 hashes (never plain text); three seeded accounts.
- Session label in the header, logout, audit trail of every add / edit / delete in `ActivityLog`.

**Citizen registration (`frmCitizen`)**
- Tabbed entry: *Personal*, *Address*, *Identity Card & Photo*.
- `MaskedTextBox` CNIC mask `00000-0000000-0`, automatic formatting, **mod-10 (Luhn) check-digit
  validation** and a "Verify Check Digit" action.
- Validation with `ErrorProvider`, required fields, date-of-birth limits, duplicate CNIC detection.
- `BindingSource` + `BindingNavigator` + `DataGridView` for browsing and searching records.
- Photo capture from the webcam (OpenCV) or from a file; photo is stored and shown on the card.
- Print-preview of the identity card through `PrintDocument` / `PrintPreviewDialog`.

**Dashboard, reports and data**
- KPI cards (total, verified, pending, registered today), recent-registrations grid, verification
  progress bar, `MonthCalendar`, quick actions.
- Statistics form with charts (gender split, province distribution, age bands) via
  `System.Windows.Forms.DataVisualization.Charting`.
- Free-text search (CNIC / name / city / province), CSV export.
- Database backup / restore (`FolderBrowserDialog`), integrity check, open data folder.
- Full-screen toggle (F11) — the shell maximises and every MDI window is fitted to the work area.

**OpenCV visual module (`frmVisual`)**
- Live capture with `OpenCvSharp` (`VideoCapture`), frames rendered on a timer.
- Effects: grayscale, sepia, Canny edges, Gaussian blur, sharpen, threshold, negative, original,
  plus mirror preview and an intensity slider.
- Haar cascade frontal-face detection (`haarcascade_frontalface_default.xml`) with live detection count.
- Capture photo → save to the citizen photo folder, save snapshot, open an existing image file, reset.

## Toolbox controls used

`MenuStrip`, `ToolStrip` (+ ToolStripButton / ToolStripLabel / ToolStripTextBox / ToolStripSeparator),
`StatusStrip` (+ ToolStripStatusLabel), `ContextMenuStrip`, `TreeView`, `ListView`, `ImageList`,
`SplitContainer`, `Panel`, `TableLayoutPanel`, `TabControl`/`TabPage`, `GroupBox`, `Label`, `LinkLabel`,
`Button`, `TextBox`, `MaskedTextBox`, `RichTextBox`, `ComboBox`, `CheckedListBox`, `CheckBox`,
`RadioButton`, `NumericUpDown`, `TrackBar`, `ProgressBar`, `DateTimePicker`, `MonthCalendar`,
`PictureBox`, `DataGridView`, `BindingSource`, `BindingNavigator`, `ErrorProvider`, `ToolTip`,
`Timer`, `NotifyIcon`, `OpenFileDialog`, `SaveFileDialog`, `FolderBrowserDialog`, `PrintDialog`,
`PageSetupDialog`, `PrintDocument`, `PrintPreviewDialog`, `Chart`.

## Getting started

1. Open `NADRA_CNIC_System/NADRA_CNIC.sln` in Visual Studio 2022 (or newer) with the
   *.NET desktop development* workload.
2. Build and run (F5). The Access database is created and seeded on first launch in
   `%APPDATA%\NADRA_CNIC_System\nadra.mdb`.
3. Sign in with one of the seeded accounts:

   | User name | Password | Role |
   |---|---|---|
   | `admin` | `nadra123` | Administrator |
   | `officer` | `officer123` | Verification Officer |
   | `operator` | `operator123` | Data Entry Operator |

4. `NADRA_CNIC.exe --skip-login` starts straight in the shell (used for demos and screen captures).

The OpenCvSharp packages are committed under `NADRA_CNIC_System/packages`, so no NuGet restore is
needed. A 32-bit build (`x86`) is used because the Jet OLE DB provider is 32-bit.

## Project layout

```
NADRA_CNIC_System/
  NADRA_CNIC.sln
  NADRA_CNIC/
    Startup.vb               application entry point, database bootstrap
    Core/                    Db, Auth/Session, Citizen model + store, VisionEngine, UiTheme, AppPaths
    Forms/                   frmLogin, frmMain (MDI shell), frmDashboard, frmCitizen,
                             frmVisual, frmStats, frmAbout
    Printing/CnicPrint.vb    identity-card print document
    Data/                    Haar cascade for face detection
selftest/                    headless self-test of the data layer and the OpenCV pipeline
```

## Self-test

`selftest/selftest.vbproj` runs the data layer and the OpenCV pipeline without a UI and reports
pass/fail for: database creation and schema, seed data, CNIC check digit, insert / update / select /
search / delete, login and password hashing, backup, integrity report, every image effect, native
OpenCV loading, face detection and JPEG capture.

```
cd selftest
msbuild selftest.vbproj -t:Restore;Build
bin\Debug\net48\selftest.exe
```

---

*Academic project. NADRA name and logo are used for coursework illustration only.*
