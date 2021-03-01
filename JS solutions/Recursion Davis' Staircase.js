let cache = new Set();
function stepPerms(n) {
    if (cache[n]) return cache[n];
    if (n === 0) return 1;
    if (n < 0) return 0;
    cache[n] = stepPerms(n-1) + stepPerms(n-2) + stepPerms(n-3);
    return cache[n];
}
console.log(stepPerms(5));