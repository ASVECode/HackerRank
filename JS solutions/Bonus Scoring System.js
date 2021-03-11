function bonusScoringSystem(arr) {
    let numOfStudents = Number(arr.shift());
    let numOfLectures = Number(arr.shift());
    let additionalBonus = Number(arr.shift());

    arr = arr.sort((a, b) => b - a);
    let studentAttendances = Number(arr[0]);
    let maxBonus = studentAttendances / numOfLectures * (5 + additionalBonus);

    return (`Max Bonus: ${Math.ceil(maxBonus)}.\nThe student has attended ${studentAttendances} lectures.`);
}

console.log(bonusScoringSystem([
    '5', '25', '30',
    '12', '19', '24',
    '16', '20'
]));

console.log(bonusScoringSystem([
    '10', '30', '14', '8',
    '23', '27', '28', '15',
    '17', '25', '26', '5',
    '18'
]
))
