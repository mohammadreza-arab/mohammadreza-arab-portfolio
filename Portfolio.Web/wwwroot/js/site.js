const io = new IntersectionObserver((entries) => {
    entries.forEach(e => { if (e.isIntersecting) { e.target.classList.add('in'); io.unobserve(e.target); } });
}, { threshold: 0.12 });
document.querySelectorAll('.reveal').forEach(el => io.observe(el));

// mobile menu
const style = document.createElement('style');
style.textContent = `.nav-links.open{display:flex;position:absolute;top:64px;left:0;right:0;background:var(--paper);
    flex-direction:column;gap:0;border-bottom:1px solid var(--line);padding:8px 24px 16px;}
    .nav-links.open a{padding:12px 0;border-bottom:1px solid var(--line);}`;
document.head.appendChild(style);