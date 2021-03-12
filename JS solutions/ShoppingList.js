// function shoppingList(arr) {
//     let groceries = arr.shift().split('!');
//     let line, command, item, i;
//     while (true) {
//         line = arr.shift();
//         if (line == 'Go Shopping!') break;
//         line=line.split(' ');
//         command = line[0], item = line[1];
//         if (command == 'Urget' && !groceries.includes(item)) {
//             groceries.unshift(item)
//         } else if ((command == 'Unnecessary' || command == 'Correct') && groceries.includes(item)) {
//             i = groceries.indexOf(item);
//             command == 'Unnecessary' ? groceries.splice(i, 1) : groceries.splice(i, 1, line[2]);
//         } else if (command == 'Rearrange' && groceries.includes(item)) {
//             i = groceries.indexOf(item);
//             groceries.splice(i, 1);
//             groceries.push(item);
//         }
//     }
//     return groceries.join(', ');
// }
function foo(arr) {
    arr = arr.filter(x => x !== "")
    let groceries = arr.shift().split("!")
    const actions = {
        Urgent: urgent,
        Unnecessary: unnecessary,
        Correct: correct,
        Rearrange: rearrange,
        Go: goShopping,
    }

    function getIndex(item) {
        if (groceries.includes(item)) {
            return groceries.findIndex(x => x === item)
        }
    }

    function urgent(item) {
        if (!groceries.includes(item)) {
            groceries.unshift(item)
        }
    }

    function unnecessary(item) {
        if (getIndex(item) !== undefined) {
            groceries.splice(getIndex(item), 1)
        }
    }

    function correct(oldItem, newItem) {
        if (getIndex(oldItem) !== undefined) {
            groceries[getIndex(oldItem)] = newItem
        }
    }

    function rearrange(item) {
        if (getIndex(item) !== undefined) {
            groceries.splice(getIndex(item), 1)
            groceries.push(item)
        }
    }

    function goShopping() {
        console.log(groceries.join(", "))
    }

    for (let i = 0; i < arr.length; i++) {
        const [action, param1, param2] = arr[i].split(" ")
        actions[action](param1, param2)
        if (action === "Go") break
    }
}
let num1=12
let num2=17.8
let str=true
let result = num1>=12 && num2<4.567 || str==true;
console.log(result)
//console.log(shoppingList(['Tomatoes!Potatoes!Bread',
 //   'Unnecessary Milk',
 //   'Urgent Tomatoes',
 //   'Go Shopping!']))

    console.log(foo(['Milk!Pepper!Salt!Water!Banana',
        'Urgent Salt',
        'Unnecessary Grapes',
        'Correct Pepper Onion',
        'Rearrange Grapes',
        'Correct Tomatoes Potatoes',
        'Go Shopping!'
        ]))