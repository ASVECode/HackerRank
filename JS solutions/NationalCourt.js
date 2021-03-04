function nationalCourt(arr) {
    emp1 = Number(arr[0]);
    emp2 = Number(arr[1]);
    emp3 = Number(arr[2]);
    numOfStudents = Number(arr[3]);
    let countHours = 0;
    let totalPerHour = Number(emp1 + emp2 + emp3);
    while (numOfStudents > 0) {
        numOfStudents -= totalPerHour;
        countHours++;
        if (countHours % 4 == 0 && countHours != 0) {
            countHours++;
        }
    }
    return `Time needed: ${countHours}h.`
}
console.log(nationalCourt([5,6,4,'20']))