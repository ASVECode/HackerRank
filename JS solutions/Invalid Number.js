function isInvalidNumber(n) {
    let num = Number(n);
    if (!(num >= 100 && num <= 200) && num != 0) {
        console.log('invalid')
    }
}
isInvalidNumber(220)