function muOnline(arr) {
    arr = arr.split('|');
    let health = 100;
    let bitcoins = 0;

    for (let i = 0; i < arr.length; i++) {
        let room = arr[i].split(' ');
        let command = room[0];
        let num = Number(room[1]);
        if (command == 'potion') {
            health += num;
            if (health > 100) {
                console.log(`You healed for ${num - Math.abs(100 - health)} hp.`);
                console.log(`Current health: 100 hp.`);
                health = 100;
            } else {
                console.log(`You healed for ${num} hp.`);
                console.log(`Current health: ${health} hp.`);
            }
        } else if (command == 'chest') {
            bitcoins += num;
            console.log(`You found ${num} bitcoins.`);
        } else {
            health -= num;
            if (health <= 0) {
                console.log(`You died! Killed by ${command}.`);
                return `Best room: ${i + 1}`;
            } else {
                console.log(`You slayed ${command}.`);
            }
        }
    }
    return `You've made it!\nBitcoins: ${bitcoins}\nHealth: ${health}`;
}
//console.log(muOnline('cat 10|potion 30|orc 10|chest 10|snake 25|chest 110'));
console.log(muOnline('rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000'));