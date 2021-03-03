function arrayModifier(array) {

    let arr = array.shift().split(' ');
    let line;
    while (true) {
        line = array.shift().split(' ');
        if (line == 'end') {
            break;
        }
        if (line[0] == 'swap') {
            let i1 = Number(line[1]);
            let i2 = Number(line[2]);
            let temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        } else if (line[0] == 'multiply') {
            let i1 = Number(line[1]);
            let i2 = Number(line[2]);
            arr[i1] = Number(arr[i1]) * Number(arr[i2]);
        } else {
            for (let i = 0; i < arr.length; i++) {
                arr[i] = Number(arr[i]) - 1;
            }
        }
    }
    arr = arr.join(', ');
    console.log(arr);
}

arrayModifier([
    '23 -2 321 87 42 90 -123',
    'swap 1 3',
    'swap 3 6',
    'swap 1 0',
    'multiply 1 2',
    'multiply 2 1',
    'decrease',
    'end'
]
)