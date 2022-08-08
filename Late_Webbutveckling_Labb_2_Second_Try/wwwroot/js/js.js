//const routeToAPI = 'api'; //TA BORT (eller ha kvar?)

//let showAllCourses = [];
//let showSelectedCourse = [];
//let showAllUsers = [];
//let showSelectedUser = [];

//let rowCounter = 0;

async function ShowingAllCourses() {

    //const allCourses = fetch('api/GetAllCourses').then(gettingCourses => gettingCourses.json());
    const allCourses = await fetch('api/getallcourses').then(gettingCourses => gettingCourses.json());
    
    const tableBody = document.getElementById('showAllCourses');
    tableBody.innerHTML = '';

    //console.log("Next line is the array.");
    console.log("Starting to load courses list");

    Array.from(allCourses).forEach(course => {
        
        //console.log("First line of array reached!");

        let newTableRow = tableBody.insertRow();

        let tableDataOne = newTableRow.insertCell(0);
        tableDataOne.appendChild(document.createTextNode(course.id));

        let tableDataTwo = newTableRow.insertCell(1);
        tableDataTwo.appendChild(document.createTextNode(course.courseTitle));

        let tableDataThree = newTableRow.insertCell(2);
        tableDataThree.appendChild(document.createTextNode(course.courseDescription));

        let tableDataFour = newTableRow.insertCell(3);
        tableDataFour.appendChild(document.createTextNode(course.courseNumber));

        let tableDataFive = newTableRow.insertCell(4);
        tableDataFive.appendChild(document.createTextNode(course.courseLength));

        let tableDataSix = newTableRow.insertCell(5);
        tableDataSix.appendChild(document.createTextNode(course.courseDifficulty));

        let tableDataSeven = newTableRow.insertCell(6);
        tableDataSeven.appendChild(document.createTextNode(course.courseStatus));

        //console.log("Last line of array reached!");

        //rowCounter++;

    });

    showAllCourses = allCourses;

    //console.log("End of function!");
    console.log("Finished loading list");

}

async function ShowingSelectedCourse(loadId) {

    const selectedCourse = await fetch(`api/GetSelectedCourse/${loadId}`, { method: 'GET' })
    .then(gettingCourse => gettingCourse.json());

    const tableBody = document.getElementById('showSelectedCourse');
    tableBody.innerHTML = '';

    console.log("Loading course");

    let newTableRow = tableBody.insertRow();

    let tableDataOne = newTableRow.insertCell(0);
    tableDataOne.appendChild(document.createTextNode(selectedCourse.id));

    let tableDataTwo = newTableRow.insertCell(1);
    tableDataTwo.appendChild(document.createTextNode(selectedCourse.courseTitle));

    let tableDataThree = newTableRow.insertCell(2);
    tableDataThree.appendChild(document.createTextNode(selectedCourse.courseDescription));

    let tableDataFour = newTableRow.insertCell(3);
    tableDataFour.appendChild(document.createTextNode(selectedCourse.courseNumber));

    let tableDataFive = newTableRow.insertCell(4);
    tableDataFive.appendChild(document.createTextNode(selectedCourse.courseLength));

    let tableDataSix = newTableRow.insertCell(5);
    tableDataSix.appendChild(document.createTextNode(selectedCourse.courseDifficulty));

    let tableDataSeven = newTableRow.insertCell(6);
    tableDataSeven.appendChild(document.createTextNode(selectedCourse.courseStatus));

    showSelectedCourse = selectedCourse;

    console.log("Course loaded");

}

async function ShowingAllUsers() {

    const allUsers = await fetch('api/GetAllUsers').then(gettingUsers => gettingUsers.json());

    const tableBody = document.getElementById('showAllUsers');
    tableBody.innerHTML = '';

    console.log("Starting to load users list");

    Array.from(allUsers).forEach(user => {
        
        let newTableRow = tableBody.insertRow();

        let tableDataOne = newTableRow.insertCell(0);
        tableDataOne.appendChild(document.createTextNode(user.id));

        let tableDataTwo = newTableRow.insertCell(1);
        tableDataTwo.appendChild(document.createTextNode(user.firstName));

        let tableDataThree = newTableRow.insertCell(2);
        tableDataThree.appendChild(document.createTextNode(user.lastName));

        let tableDataFour = newTableRow.insertCell(3);
        tableDataFour.appendChild(document.createTextNode(user.email));

        let tableDataFive = newTableRow.insertCell(4);
        tableDataFive.appendChild(document.createTextNode(user.phone));

        let tableDataSix = newTableRow.insertCell(5);
        tableDataSix.appendChild(document.createTextNode(user.mailRecipient));

        let tableDataSeven = newTableRow.insertCell(6);
        tableDataSeven.appendChild(document.createTextNode(user.street));

        let tableDataEight = newTableRow.insertCell(7);
        tableDataEight.appendChild(document.createTextNode(user.zipCode));

        let tableDataNine = newTableRow.insertCell(8);
        tableDataNine.appendChild(document.createTextNode(user.city));

        let tableDataTen = newTableRow.insertCell(9);
        tableDataTen.appendChild(document.createTextNode(user.country));

    });
    
    showAllUsers = allUsers;

    console.log("Finished loading list");

}

async function ShowingSelectedUser(loadEmail) {

    const selectedUser = await fetch(`api/GetUserByEmail/${loadEmail}`, { method: 'GET' })
    .then(gettingUser => gettingUser.json());

    const tableBody = document.getElementById('showSelectedUser');
    tableBody.innerHTML = '';

    console.log("Loading user");

    let newTableRow = tableBody.insertRow();

    let tableDataOne = newTableRow.insertCell(0);
    tableDataOne.appendChild(document.createTextNode(selectedUser.id));

    let tableDataTwo = newTableRow.insertCell(1);
    tableDataTwo.appendChild(document.createTextNode(selectedUser.firstName));

    let tableDataThree = newTableRow.insertCell(2);
    tableDataThree.appendChild(document.createTextNode(selectedUser.lastName));

    let tableDataFour = newTableRow.insertCell(3);
    tableDataFour.appendChild(document.createTextNode(selectedUser.email));

    let tableDataFive = newTableRow.insertCell(4);
    tableDataFive.appendChild(document.createTextNode(selectedUser.phone));

    let tableDataSix = newTableRow.insertCell(5);
    tableDataSix.appendChild(document.createTextNode(selectedUser.mailRecipient));

    let tableDataSeven = newTableRow.insertCell(6);
    tableDataSeven.appendChild(document.createTextNode(selectedUser.street));

    let tableDataEight = newTableRow.insertCell(7);
    tableDataEight.appendChild(document.createTextNode(selectedUser.zipCode));

    let tableDataNine = newTableRow.insertCell(8);
    tableDataNine.appendChild(document.createTextNode(selectedUser.city));

    let tableDataTen = newTableRow.insertCell(9);
    tableDataTen.appendChild(document.createTextNode(selectedUser.country));

    showSelectedUser = selectedUser;

    console.log("User loaded");

}








//  /api/AddCourse
async function AddACourse() {

    const newCourseTitle = document.getElementById('CourseTitle');
    const newCourseDescription = document.getElementById('CourseDescription');
    const newCourseNumber = document.getElementById('CourseNumber');
    const newCourseLength = document.getElementById('CourseLength');
    const newCourseDifficulty = document.getElementById('CourseDifficulty');
    const newCourseStatus = document.getElementById('CourseStatus');

    const newCourse = {

        CourseTitle: newCourseTitle,
        CourseDescription: newCourseDescription,
        CourseNumber: newCourseNumber,
        CourseLength: newCourseLength,
        CourseDifficulty: newCourseDifficulty,
        //CourseStatus: newCourseStatus
        CourseStatus: true
        
    };
//  /${newCourse}
    await fetch(`api/AddCourse`, {method: 'POST',
//         body: 'Content-Type': 'application/json' 
         headers: {
             //'Content-Type': 'application/json', 

'CourseTitle': 'application/json',
        'CourseDescription': 'application/json',
        'CourseNumber': 'application/json',
        'CourseLength': 'application/json',
        'CourseDifficulty': 'application/json',
        'CourseStatus': 'application/json'

            }, 
            body: JSON.stringify(newCourse)
        })
    .then(respone => response.json())
    .then(() => { newCourseTitle.value = '';
newCourse.CourseDescription.value = '';
newCourse.CourseNumber.value = '';
newCourseLength.value = '';
newCourse.CourseDifficulty.value = '';
newCourseStatus.value = '';})
//;
}

//CourseTitle
//CourseDescription
//CourseNumber
//CourseLength
//CourseDifficulty
//CourseStatus
//Id

async function AddAUser() {

    const newFirstName = document.getElementById('FirstName');
    const newLastName = document.getElementById('LastName');
    const newEmail = document.getElementById('Email');
    const newPhone = document.getElementById('Phone');
    const newMailRecipient = document.getElementById('MailRecipient');
    const newStreet = document.getElementById('Street');
    const newZipCode = document.getElementById('ZipCode');
    const newCity = document.getElementById('City');
    const newCountry = document.getElementById('Country');

    const newUser = {

        FirstName: newFirstName.value,
        LastName: newLastName.value,
        Email: newEmail.value,
        Phone: newPhone.value,
        MailRecipient: newMailRecipient.value,
        Street: newStreet.value,
        ZipCode: newZipCode.value,
        City: newCity.value,
        Country: newCountry.value

    }
    
}

//Id
//FirstName
//LastName
//Email
//Phone
//MailRecipient
//Street
//ZipCode
//City
//Country





















async function RetireSelectedCourse() {//retireId

    const statusOfCourse = document.getElementById('CourseStatus').value;

//    const newStatusOfCourse = {
//
//        id: parseInt(statusOfCourse, 10),
//        courseStatus: document.getElementById('CourseStatus').value
//
//    }

    //fetch(`api/RetireCourse/${retireId}`), {
    fetch(`api/RetireCourse/${statusOfCourse}`, {

        method: 'PUT',
        headers: {

            'Accept': 'application/json',
            'Content-Type': 'application/json'

        },
        body: JSON.stringify(statusOfCourse)

    });

}




























/*async function loadIntoTable(url, table) {

    const tableHead = table.querySelector("thead");
    const tableBody = table.querySelector("tbody");

    const response = await;

}

loadIntoTable("api/getallcourses", document.querySelector("myTestTable"));*/