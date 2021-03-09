function inventory(arr) {
    let journal = arr.shift().split(', ');
    let line;
    while (true) {
        line = arr.shift();
        if (line == 'Craft!') {
            break;
        }
        line = line.split(' - ');
        let command = line[0];
        let item = line[1];

        if (command == 'Collect' && !journal.includes(item)) {
            journal.push(item);
        } else if (command == 'Drop' && journal.includes(item)) {
            let i = journal.indexOf(item);
            journal.splice(i, 1);
        } else if (command == 'Renew' && journal.includes(item)) {
            let i = journal.indexOf(item);
            journal.splice(i, 1);
            journal.push(item);
        } else if (command == 'Combine Items') {
            item = item.split(':');
            if (journal.includes(item[0])) {
                let i = journal.indexOf(item[0]);
                journal.splice(i + 1, 0, item[1]);
            }
        }
    }

    return journal.join(', ');
}
console.log(inventory(['Iron, Wood, Sword', 'Collect - Gold', 'Drop - Wood', 'Craft!']));
// console.log(inventory([
//     'Iron, Sword',
//     'Drop - Bronze',
//     'Combine Items - Sword:Bow',
//     'Renew - Iron',
//     'Craft!'
// ]));