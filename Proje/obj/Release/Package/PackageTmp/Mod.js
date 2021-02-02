document.getElementById('sec').addEventListener('click', () => {
    document.body.classList.toggle('dark');
    localStorage.setItem('mode', document.body.classList);
});

if (localStorage.getItem('mode') != '') {
    document.body.classList.add(localStorage.getItem('mode'));
    document.getElementById('sec').checked = true;
}