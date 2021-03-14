function numbers(arr) {

    arr = arr.split(' ').map(Number).sort((a, b) => b - a);
    let avarage = arr.reduce((accumulator, currentValue) => accumulator + currentValue) / arr.length;
    let result = arr.splice(0, 5).filter(x => x > avarage);

    if (result.length == 0) {
        return 'No';
    }
    return result.join(' ');
}
console.log(numbers('5 2 3 4 -10 30 40 50 20 50 60 60 51'));
console.log(numbers('10 20 30 40 50'));
console.log(numbers('1'));
console.log(numbers('-1 -2 -3 -4 -5 -6'));


