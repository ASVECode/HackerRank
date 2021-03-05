function lift(arr) {
    let totalPeople = Number(arr.shift());
    let places = arr.shift().split(' ').map(Number);
    let liftPlaces = places.length;
    let freePlaces = liftPlaces * 4 - places.reduce((a, b) => a + b, 0);
    let i = 0
    while (freePlaces > 0 || totalPeople > 0) {
        if (places[i] < 4) {
            if (4 - places[i] > totalPeople) {
                places[i] += totalPeople
                totalPeople = 0
                break;
            }
            totalPeople -= (4 - places[i])
            freePlaces -= (4 - places[i])
            places[i] += (4 - places[i]);
        }
        i++;
        if (i > liftPlaces) {
            break;
        }
    }
    if (places.reduce((a, b) => a + b, 0) == liftPlaces * 4 && totalPeople > 0) {
        console.log(`There isn't enough space! ${totalPeople} people in a queue!`)
    } else if (places.reduce((a, b) => a + b, 0) < liftPlaces * 4 && totalPeople == 0) {
        console.log(`The lift has empty spots!`)
    }
    console.log(places.join(' '));
}
lift([15,
    '0 0 0 1'
])
// lift([20,
//     '0 2 0'
// ])