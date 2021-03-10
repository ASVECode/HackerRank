function memoryGame(arr) {
    let elements = arr.shift().split(' ');
    let moves = 0;

    while (true) {
        [i1, i2] = arr.shift().split(' ');
        if (i1 === 'end' || i2 == undefined) {
            break;
        }
        if (elements.length === 0 || elements.length === 1) {
            console.log(`You have won in ${moves} turns!`);
            return;
        }
        moves++;
        if (i1 === i2 || +i1 < 0 || +i1 >= elements.length || +i2 < 0 || +i2 >= elements.length|| elements.length === 0) {
            console.log(`Invalid input! Adding additional elements to the board`)
            //adding in the middle
            let j = Math.floor(elements.length / 2);
            elements.splice(j, 0, `-${moves}a`)
            elements.splice(j, 0, `-${moves}a`)
            continue;
        }
        if (elements[+i1] === elements[+i2]) {
            console.log(`Congrats! You have found matching elements - ${elements[+i1]}!`)
            if (i1 > i2) {
                let temp = i1;
                i1 = i2;
                i1 = temp;
            }
            elements.splice(+i1, 1)
            i2 == 0 ? elements.splice(+i2, 1) : elements.splice(+i2 - 1, 1)
        } else if(elements[+i1] !== elements[+i2]){
            console.log('Try again!')
        }
    }
    if (elements.length > 0) {
        console.log(`Sorry you lose :(`);
        console.log(`${elements.join(' ')}`)
    }
}
memoryGame([
    "1 1 2 2 3 3 4 4 5 5",
    "1 0",
    "-1 0",
    "1 0",
    "1 0",
    "1 0",
    "end"
]
)
memoryGame([
    "a 2 4 a 2 4",
    "0 3",
    "0 2",
    "0 1",
    "0 1",
    "end"
]
)

memoryGame([
    "a 2 4 a 2 4",
    "4 0",
    "0 2",
    "0 1",
    "0 1",
    "end"
]

)