function enmojidetector(arr) {
    let regex = /((::)|(\*\*))[A-Z][a-z]{2,}\1/g;
    let regexDigits = /\d/g;
    let treshold = arr[0].match(regexDigits).map(Number).reduce((a, b) => a * b, 1);
    console.log(`Cool threshold: ${treshold}`);

    let emojis = arr[0].match(regex);
    console.log(emojis)
    console.log(`${emojis.length} emojis found in the text. The cool ones are:`);
    let coolEmojis = emojis.map(e => {
        let coolness = e.split('')
            .splice(2, e.length - 4)
            .map(char => char.charCodeAt())
            .reduce((a, b) => a + b, 0);
        if (coolness > treshold) {
            console.log(e);
        }
        return coolness;

    })

}

console.log(enmojidetector([
    'In the Sofia Zoo there are 311 animals in total! ::Smiley:: This includes 3 **Tigers**, 1 ::Elephant:, 12 **Monk3ys**, a **Gorilla::, 5 ::fox:es: and 21 different types of :Snak::Es::. ::Mooning:: **Shy**'
]))