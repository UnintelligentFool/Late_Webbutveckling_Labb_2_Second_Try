async function ShowingAllCourses() {

    const allCourses = await fetch('api/getallcourses').then(gettingCourses => gettingCourses.json());
    
    const tableBody = document.getElementById('showAllCourses');
    tableBody.innerHTML = '';

    console.log("Starting to load courses list");

    Array.from(allCourses).forEach(course => {
        
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

    });

    showAllCourses = allCourses;

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



async function AddACourse(CourseTitle, CourseDescription, CourseNumber, CourseLength, CourseDifficulty) {

    console.log("Preparing to add a course...");

    const newCourse = {

        CourseTitle: CourseTitle,
        CourseDescription: CourseDescription,
        CourseNumber: CourseNumber,
        CourseLength: CourseLength,
        CourseDifficulty: CourseDifficulty,
        CourseStatus: true,
        UserId: ""
        
    };

    await fetch(`api/AddCourse`, 
    {method: 'POST', headers: {
        'Content-Type': 'application/json'
        },
        body: JSON.stringify(newCourse)
    });

    console.log("Course added!");

}



async function AddAUser(FirstName, LastName, Email, Phone, MailRecipient, Street, ZipCode, City, Country) {

    console.log("Preparing to add a user...");

    const newUser = {

        FirstName: FirstName,
        LastName: LastName,
        Email: Email,
        Phone: Phone,
        MailRecipient: MailRecipient,
        Street: Street,
        ZipCode: ZipCode,
        City: City,
        Country: Country

    };

    await fetch('api/AddUser', 
    {method: 'POST', 
    headers: { 'Content-Type': 'application/json' }, 
    body: JSON.stringify(newUser)});

    console.log("User added!");
    
}



async function UpdateAUser(Id, FirstName, LastName, Email, Phone, MailRecipient, Street, ZipCode, City, Country) {

    console.log("Preparing to update a user...");

    const updateUser = {

        Id: Id,
        FirstName: FirstName,
        LastName: LastName,
        Email: Email,
        Phone: Phone,
        MailRecipient: MailRecipient,
        Street: Street,
        ZipCode: ZipCode,
        City: City,
        Country: Country

    };

    await fetch('api/UpdateUserProfile', 
    {method: 'PUT', 
    headers: { 'Content-Type': 'application/json' }, 
    body: JSON.stringify(updateUser)});

    console.log("User updated!");
    
}

    

async function RetireSelectedCourse(retireId) {//retireId
  
    console.log("Retiring course");

      const newStatusOfCourse = {
  
        Id: retireId//,
  
      };
  
      await fetch(`api/RetireCourse`, 
      {method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(newStatusOfCourse)});
  
      console.log("Course retired.");
  
}



async function DeleteCourse(deleteId) {

    await fetch(`api/DeleteCourse/${deleteId}`, { method: 'DELETE' });

}



async function AddingCourseToUser(toThisUser, addThisCourse) {

    console.log("Preparing to add course to user");

    const thisCourse = {

        Id: addThisCourse,
        UserId: toThisUser

    }

    await fetch(`api/AddCourseToUserProfile/${toThisUser}/${addThisCourse}`, 
    { method: 'PUT',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(thisCourse)});

    console.log("Course assigned.");

}