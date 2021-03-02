function sherlockAndAnagrams(s) {
    let count = 0;

    // Size of our sliding window
    for (let i = 1; i < s.length; i++) {
        let found = {};
        
        // Starting index of our sliding window
        for (let j = 0; j + i <= s.length; j++) {
            let substr = s.substr(j, i);
            substr = substr.split('').sort().join('');
            if (found[substr]) {
                count += found[substr];
                found[substr]++;
            } else {
                found[substr] = 1;
            }
        }
    }

    return count;
}

console.log(sherlockAndAnagrams('cdcd'))