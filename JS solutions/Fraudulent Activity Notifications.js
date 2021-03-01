function activityNotifications(expenditure, d) {
    let m, newArr = new Array(201).fill(0), notifications = 0;
    for (let i = 0, j = d; i < expenditure.length; i++, j++) {
        if (expenditure[j] == undefined) break;
        newArr = expenditure.slice(i, j).sort();
        m = d % 2 != 0 ? newArr[Math.floor(newArr.length / 2)] :
            (newArr[Math.floor(newArr.length / 2 - 1)] + newArr[Math.floor(newArr.length / 2)]) / 2;
        if (m * 2 <= expenditure[j]) notifications++;
    }

    return notifications;
}
// console.log(activityNotifications([10, 20, 30, 40, 50], 3));
// console.log(activityNotifications([1, 2, 3, 4, 4], 4));
console.log(activityNotifications([2, 3, 4, 2, 3, 6, 8, 4, 5], 5));
