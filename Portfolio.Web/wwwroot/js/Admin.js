const I = {
    grid: '<path d="M3 3h7v7H3zM14 3h7v7h-7zM14 14h7v7h-7zM3 14h7v7H3z"/>',
    folder: '<path d="M3 7a2 2 0 0 1 2-2h4l2 2h8a2 2 0 0 1 2 2v8a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"/>',
    badge: '<path d="M12 15a4 4 0 1 0 0-8 4 4 0 0 0 0 8z"/><path d="M9 14l-2 7 5-3 5 3-2-7"/>',
    globe: '<circle cx="12" cy="12" r="9"/><path d="M3 12h18M12 3a15 15 0 0 1 0 18M12 3a15 15 0 0 0 0 18"/>',
    clock: '<circle cx="12" cy="12" r="9"/><path d="M12 7v5l3 2"/>',
    spark: '<path d="M12 3v4M12 17v4M3 12h4M17 12h4M6 6l2 2M16 16l2 2M18 6l-2 2M8 16l-2 2"/>',
    img: '<rect x="3" y="3" width="18" height="18" rx="2"/><circle cx="8.5" cy="8.5" r="1.5"/><path d="M21 15l-5-5L5 21"/>',
};

/* ---------- entity config (drives table + form) ---------- */
const ENTITIES = {
    projekte: {
        label: 'Projekte', singular: 'Projekt', icon: I.folder,
        columns: ['Vorschau', 'Projekt', 'Tech', 'Links'],
        fields: [
            { key: 'title', label: 'Titel', type: 'text', required: true },
            { key: 'description', label: 'Beschreibung', type: 'textarea', required: true },
            { key: 'tech', label: 'Tech-Stack', type: 'text', hint: 'kommagetrennt, z. B. ASP.NET Core, EF Core, JWT' },
            { key: 'image', label: 'Screenshot-Pfad', type: 'text', hint: 'z. B. projects/task-manager.png' },
            { key: 'github', label: 'GitHub-URL', type: 'url' },
            { key: 'demo', label: 'Live-Demo-URL', type: 'url' },
        ],
        row: (it) => `
      <td>${thumb(it.image)}</td>
      <td><div class="t-title">${esc(it.title)}</div><div class="t-sub">${esc(trim(it.description, 60))}</div></td>
      <td><div class="tag-row">${tags(it.tech)}</div></td>
      <td><div class="t-sub">${it.github ? 'GitHub' : ''}${it.github && it.demo ? ' · ' : ''}${it.demo ? 'Demo' : ''}${!it.github && !it.demo ? '—' : ''}</div></td>`,
    },
    zertifikate: {
        label: 'Zertifikate', singular: 'Zertifikat', icon: I.badge,
        columns: ['Vorschau', 'Zertifikat', 'Aussteller', 'Jahr'],
        fields: [
            { key: 'title', label: 'Titel', type: 'text', required: true },
            { key: 'issuer', label: 'Aussteller', type: 'text', required: true, hint: 'z. B. Microsoft Learn, Udemy' },
            { key: 'year', label: 'Jahr', type: 'text' },
            { key: 'image', label: 'Bild-/PDF-Pfad', type: 'text', hint: 'z. B. certs/csharp.jpg' },
        ],
        row: (it) => `
      <td>${thumb(it.image)}</td>
      <td><div class="t-title">${esc(it.title)}</div></td>
      <td><div class="t-sub">${esc(it.issuer || '—')}</div></td>
      <td><span class="pillg">${esc(it.year || '—')}</span></td>`,
    },
    sprachen: {
        label: 'Sprachen', singular: 'Sprache', icon: I.globe,
        columns: ['Sprache', 'Niveau (CEFR)'],
        fields: [
            { key: 'name', label: 'Sprache', type: 'text', required: true },
            { key: 'level', label: 'Niveau', type: 'select', options: ['Muttersprache', 'C2', 'C1', 'B2', 'B1', 'A2', 'A1'], required: true },
        ],
        row: (it) => `
      <td><div class="t-title">${esc(it.name)}</div></td>
      <td><span class="pillv">${esc(it.level)}</span></td>`,
    },
    werdegang: {
        label: 'Werdegang', singular: 'Eintrag', icon: I.clock,
        columns: ['Typ', 'Eintrag', 'Ort', 'Zeitraum'],
        fields: [
            { key: 'type', label: 'Typ', type: 'select', options: ['Berufserfahrung', 'Bildung'], required: true },
            { key: 'period', label: 'Zeitraum', type: 'text', required: true, hint: 'z. B. 2024 — heute' },
            { key: 'title', label: 'Titel / Position', type: 'text', required: true },
            { key: 'place', label: 'Ort / Institution', type: 'text' },
            { key: 'description', label: 'Beschreibung', type: 'textarea' },
        ],
        row: (it) => `
      <td><span class="${it.type === 'Bildung' ? 'pillg' : 'pillv'}">${esc(it.type)}</span></td>
      <td><div class="t-title">${esc(it.title)}</div><div class="t-sub">${esc(trim(it.description, 55))}</div></td>
      <td><div class="t-sub">${esc(it.place || '—')}</div></td>
      <td><div class="t-sub">${esc(it.period)}</div></td>`,
    },
    learning: {
        label: 'Learning Journey', singular: 'Thema', icon: I.spark,
        columns: ['Thema', 'Notiz', 'Status'],
        fields: [
            { key: 'title', label: 'Thema', type: 'text', required: true },
            { key: 'note', label: 'Notiz', type: 'textarea' },
            { key: 'status', label: 'Status', type: 'select', options: ['lerne gerade', 'laufend', 'als Nächstes'], required: true },
        ],
        row: (it) => `
      <td><div class="t-title">${esc(it.title)}</div></td>
      <td><div class="t-sub">${esc(trim(it.note, 60))}</div></td>
      <td><span class="${it.status === 'als Nächstes' ? 'pillg' : 'pillv'}">${esc(it.status)}</span></td>`,
    },
};

/* ---------- seed data (aus dem Portfolio) ---------- */
let DB = {
    projekte: [
        { id: id(), title: 'Task-Manager API', description: 'REST-API zum Verwalten von Aufgaben und Projekten mit Authentifizierung.', tech: 'ASP.NET Core, EF Core, JWT, SQL Server', image: 'projects/task-manager.png', github: '#', demo: '#' },
        { id: id(), title: 'Lagerverwaltung', description: 'CRUD-Webanwendung: Produkte, Lagerbestände und einfache Auswertungen.', tech: 'Razor Pages, EF Core, PostgreSQL', image: 'projects/inventory.png', github: '#', demo: '#' },
        { id: id(), title: 'Wetter-Dashboard', description: 'Frontend, das eine öffentliche Wetter-API nutzt und eine responsive Vorhersage zeigt.', tech: 'JavaScript, Fetch API, CSS Grid', image: 'projects/weather.png', github: '#', demo: '#' },
        { id: id(), title: 'Blog-Engine', description: 'Blog mit Markdown-Editor und Admin-Bereich für Authentifizierung und CRUD.', tech: 'ASP.NET Core, Identity, SQLite', image: 'projects/blog-engine.png', github: '#', demo: '#' },
    ],
    zertifikate: [
        { id: id(), title: 'C# Fundamentals', issuer: 'Microsoft Learn', year: '2024', image: 'certs/csharp-fundamentals.jpg' },
        { id: id(), title: 'ASP.NET Core — Web APIs', issuer: 'Udemy', year: '2024', image: 'certs/aspnet-core-apis.jpg' },
        { id: id(), title: 'Entity Framework Core', issuer: 'Microsoft Learn', year: '2025', image: 'certs/ef-core.jpg' },
        { id: id(), title: 'SQL Server & Datenbankdesign', issuer: 'Udemy', year: '2023', image: 'certs/sql-server.jpg' },
    ],
    sprachen: [
        { id: id(), name: 'Persisch', level: 'Muttersprache' },
        { id: id(), name: 'Deutsch', level: 'B2' },
        { id: id(), name: 'Englisch', level: 'B2' },
    ],
    werdegang: [
        { id: id(), type: 'Berufserfahrung', period: '2024 — heute', title: 'Freiberuflicher Webentwickler', place: 'Selbstständig, Teheran', description: 'Kleine Web-Anwendungen für lokale Kunden mit ASP.NET Core.' },
        { id: id(), type: 'Berufserfahrung', period: '2023 — 2024', title: 'IT-Support (Praktikum)', place: '[Firmenname], Teheran', description: 'Anwender-Support, Fehlersuche und Dokumentation.' },
        { id: id(), type: 'Bildung', period: '2025 — 2026', title: 'Deutschkurs (A1 → B2)', place: '[Sprachinstitut]', description: 'Sprachkurs zur Vorbereitung auf die Ausbildung.' },
        { id: id(), type: 'Bildung', period: '2020 — 2024', title: 'Hochschuldiplom — Informatik', place: '[Universität], Teheran', description: 'Programmierung, Datenstrukturen, Datenbanken.' },
    ],
    learning: [
        { id: id(), title: 'Docker & Containerisierung', note: '.NET-Apps containerisieren und mit Compose betreiben.', status: 'lerne gerade' },
        { id: id(), title: 'Clean Architecture in .NET', note: 'Projekte in klare Schichten aufteilen.', status: 'lerne gerade' },
        { id: id(), title: 'Automatisiertes Testen (xUnit)', note: 'Unit- und Integrationstests für APIs.', status: 'als Nächstes' },
        { id: id(), title: 'Deutsch B2 → C1', note: 'Fachsprache und Kommunikation im Team.', status: 'laufend' },
    ],
};

/* ---------- helpers ---------- */
function id() { return 'id' + Math.random().toString(36).slice(2, 9); }
function esc(s) { return (s ?? '').toString().replace(/[&<>"]/g, c => ({ '&': '&amp;', '<': '&lt;', '>': '&gt;', '"': '&quot;' }[c])); }
function trim(s, n) { s = (s || '').toString(); return s.length > n ? s.slice(0, n - 1) + '…' : s; }
function tags(str) { return (str || '').split(',').map(t => t.trim()).filter(Boolean).map(t => `<span class="tag">${esc(t)}</span>`).join(''); }
function thumb(src) { return `<span class="thumb-cell"><svg class="thumb-ic" viewBox="0 0 24 24">${I.img}</svg>${src ? `<img src="${esc(src)}" alt="" onerror="this.remove()">` : ''}</span>`; }

/* ---------- state ---------- */
let current = 'dashboard';   // 'dashboard' or entity key
let editingId = null;

/* ---------- sidebar ---------- */
function buildNav() {
    const nav = document.getElementById('navList');
    let html = `<a class="sb-link ${current === 'dashboard' ? 'active' : ''}" onclick="go('dashboard')"><svg class="ic" viewBox="0 0 24 24">${I.grid}</svg>Dashboard</a>`;
    for (const [k, e] of Object.entries(ENTITIES)) {
        html += `<a class="sb-link ${current === k ? 'active' : ''}" onclick="go('${k}')"><svg class="ic" viewBox="0 0 24 24">${e.icon}</svg>${e.label}<span class="ct">${DB[k].length}</span></a>`;
    }
    nav.innerHTML = html;
}

/* ---------- routing ---------- */
function showView(id) {
    ['view-dashboard', 'view-entity', 'view-form'].forEach(v => document.getElementById(v).classList.toggle('active', v === id));
}
function go(key) {
    current = key; buildNav(); toggleMenu(false); editingId = null;
    if (key === 'dashboard') {
        showView('view-dashboard');
        document.getElementById('pageTitle').textContent = 'Dashboard';
        document.getElementById('pageSub').textContent = 'Überblick über deine Inhalte';
        document.getElementById('addBtn').style.display = 'none';
        renderDashboard();
    } else {
        const e = ENTITIES[key];
        showView('view-entity');
        document.getElementById('pageTitle').textContent = e.label;
        document.getElementById('pageSub').textContent = `${DB[key].length} Einträge`;
        document.getElementById('addBtn').style.display = 'inline-flex';
        document.getElementById('addLabel').textContent = e.singular + ' hinzufügen';
        renderTable(key);
    }
    window.scrollTo(0, 0);
}

function renderDashboard() {
    const host = document.getElementById('dashStats');
    host.innerHTML = Object.entries(ENTITIES).map(([k, e]) => `
    <div class="stat-card link" onclick="go('${k}')">
      <div class="num">${DB[k].length}</div>
      <div class="lbl">${e.label}</div>
    </div>`).join('');
}

function renderTable(key) {
    const e = ENTITIES[key], rows = DB[key];
    const host = document.getElementById('tableHost');
    if (!rows.length) {
        host.innerHTML = `<div class="empty"><h3>Noch nichts hier</h3><p>Füge dein erstes ${esc(e.singular)} hinzu.</p></div>`;
        return;
    }
    host.innerHTML = `
    <div class="table-scroll"><table>
      <thead><tr>${e.columns.map(c => `<th>${c}</th>`).join('')}<th style="text-align:right">Aktionen</th></tr></thead>
      <tbody>
        ${rows.map(it => `<tr>${e.row(it)}
          <td><div class="row-actions">
            <button class="icon-btn" onclick="goForm('${it.id}')" aria-label="Bearbeiten"><svg class="ic" viewBox="0 0 24 24">${'<path d=\"M12 20h9\"/><path d=\"M16.5 3.5a2.1 2.1 0 0 1 3 3L7 19l-4 1 1-4z\"/>'}</svg></button>
            <button class="icon-btn del" onclick="removeItem('${it.id}')" aria-label="Löschen"><svg class="ic" viewBox="0 0 24 24">${'<path d=\"M3 6h18M8 6V4h8v2M19 6l-1 14H6L5 6\"/>'}</svg></button>
          </div></td></tr>`).join('')}
      </tbody>
    </table></div>`;
}

/* ---------- form page (create/edit) ---------- */
function goForm(itemId) {
    if (current === 'dashboard') return;
    const e = ENTITIES[current];
    editingId = itemId || null;
    const item = editingId ? DB[current].find(x => x.id === editingId) : {};
    document.getElementById('saveBtn').textContent = editingId ? 'Änderungen speichern' : 'Anlegen';
    document.getElementById('formHost').innerHTML = e.fields.map(f => {
        const v = esc(item[f.key] ?? '');
        let input;
        if (f.type === 'textarea') input = `<textarea data-k="${f.key}">${v}</textarea>`;
        else if (f.type === 'select') input = `<select data-k="${f.key}">${f.options.map(o => `<option ${item[f.key] === o ? 'selected' : ''}>${o}</option>`).join('')}</select>`;
        else input = `<input data-k="${f.key}" type="${f.type === 'url' ? 'url' : 'text'}" value="${v}" ${f.type === 'url' ? 'placeholder="https://…"' : ''}>`;
        return `<div class="field"><label>${f.label}${f.required ? ' *' : ''}</label>${input}${f.hint ? `<div class="hint">${f.hint}</div>` : ''}</div>`;
    }).join('');
    // topbar reflects the "page"
    document.getElementById('pageTitle').textContent = (editingId ? 'Bearbeiten · ' : 'Neu · ') + e.singular;
    document.getElementById('pageSub').textContent = editingId ? 'Eintrag bearbeiten' : 'Neuen Eintrag anlegen';
    document.getElementById('addBtn').style.display = 'none';
    showView('view-form');
    window.scrollTo(0, 0);
}

function saveForm() {
    const e = ENTITIES[current];
    const inputs = document.querySelectorAll('#formHost [data-k]');
    const data = {};
    inputs.forEach(el => data[el.dataset.k] = el.value.trim());
    for (const f of e.fields) { if (f.required && !data[f.key]) { alert(`Bitte „${f.label}" ausfüllen.`); return; } }
    const wasEdit = !!editingId;
    if (editingId) {
        const i = DB[current].findIndex(x => x.id === editingId);
        DB[current][i] = { ...DB[current][i], ...data };
    } else {
        DB[current].unshift({ id: id(), ...data });
    }
    editingId = null;
    go(current);            // zurück zur Liste
    toast(wasEdit ? 'Gespeichert' : 'Angelegt');
}

function removeItem(itemId) {
    const e = ENTITIES[current];
    const item = DB[current].find(x => x.id === itemId);
    if (!confirm(`„${item.title || item.name}" wirklich löschen?`)) return;
    DB[current] = DB[current].filter(x => x.id !== itemId);
    buildNav(); renderTable(current);
    document.getElementById('pageSub').textContent = `${DB[current].length} Einträge`;
    toast('Gelöscht', true);
}

/* ---------- toast ---------- */
function toast(msg, isDel) {
    const t = document.createElement('div');
    t.className = 'toast' + (isDel ? ' del' : '');
    t.innerHTML = `<span class="dot"></span>${esc(msg)}`;
    document.getElementById('toasts').appendChild(t);
    setTimeout(() => { t.style.opacity = '0'; t.style.transition = 'opacity .3s'; setTimeout(() => t.remove(), 300); }, 2200);
}

/* ---------- mobile menu ---------- */
function toggleMenu(open) {
    document.getElementById('sidebar').classList.toggle('open', open);
    document.getElementById('scrim').classList.toggle('open', open);
}

/* Esc auf der Formularseite -> zurück zur Liste */
document.addEventListener('keydown', e => {
    if (e.key === 'Escape' && document.getElementById('view-form').classList.contains('active')) go(current);
});

/* init */
buildNav(); go('dashboard');