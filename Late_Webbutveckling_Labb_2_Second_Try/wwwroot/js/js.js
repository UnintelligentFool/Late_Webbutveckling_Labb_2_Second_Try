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



//        //  /api/AddCourse
//        async function AddACourse() {
//        
//            const newCourseTitle = document.getElementById('CourseTitle');
//            const newCourseDescription = document.getElementById('CourseDescription');
//            const newCourseNumber = document.getElementById('CourseNumber');
//            const newCourseLength = document.getElementById('CourseLength');
//            const newCourseDifficulty = document.getElementById('CourseDifficulty');
//            const newCourseStatus = document.getElementById('CourseStatus');
//        
//            const newCourse = {
    //        
//                CourseTitle: newCourseTitle,
//                CourseDescription: newCourseDescription,
//                CourseNumber: newCourseNumber,
//                CourseLength: newCourseLength,
//                CourseDifficulty: newCourseDifficulty,
//                //CourseStatus: newCourseStatus
//                CourseStatus: true,
//                UserId: ""
//                
//            };
//        //  /${newCourse}
//        
//            await fetch(`api/AddCourse`, 
//            {method: 'POST',
//        //         body: 'Content-Type': 'application/json' 
//                 headers: {
//        //            'Accept': 'application/json',
//              'Content-Type': 'application/json'
//                     //'Content-Type': 'application/json', 
        //        
//        //'CourseTitle': 'application/json',
//        //        'CourseDescription': 'application/json',
//        //        'CourseNumber': 'application/json',
//        //        'CourseLength': 'application/json',
//        //        'CourseDifficulty': 'application/json',
//        //        'CourseStatus': 'application/json'
        //        
//                    }, 
//                    body: JSON.stringify(newCourse)
//                })
//        //    .then(response => response.json())
//        //    .then(() => { newCourseTitle.value = '';
//        //newCourse.CourseDescription.value = '';
//        //newCourse.CourseNumber.value = '';
//        //newCourseLength.value = '';
//        //newCourse.CourseDifficulty.value = '';
//        //newCourseStatus.value = '';})
//        ;
//        }



async function AddAUser(FirstName, LastName, Email, Phone, MailRecipient, Street, ZipCode, City, Country) {

//    const newFirstName = document.getElementById('FirstName');
//    const newLastName = document.getElementById('LastName');
//    const newEmail = document.getElementById('Email');
//    const newPhone = document.getElementById('Phone');
//    const newMailRecipient = document.getElementById('MailRecipient');
//    const newStreet = document.getElementById('Street');
//    const newZipCode = document.getElementById('ZipCode');
//    const newCity = document.getElementById('City');
//    const newCountry = document.getElementById('Country');

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






























//async function RetireSelectedCourse(retireId) {//retireId
//
//    const statusOfCourse = retireId;
//
//    const newStatusOfCourse = {
//
//        id: parseInt(statusOfCourse, 10),
//
//    }
//
//    console.log("Retiring course");
//
//    await fetch(`api/RetireCourse/${retireId}`, {
//    //await fetch(`api/RetireCourse/${statusOfCourse}`, {
//
//        method: 'PUT',
//        headers: {
//
//            //'Accept': 'application/json',
//            'Content-Type': 'application/json'
//
//        },
//        body: JSON.stringify()
//
//    });
//
//    console.log("Course retired.");
//
//}























//    async function RetireSelectedCourse(retireId) {//retireId
//    
//        console.log(retireId);
//    
//        const statusOfCourse = {
    //    
//            //id: parseInt(retireId, 10)
//            id: retireId,
//            CourseStatus: false
    //    
//        };
//    
//    //    const newStatusOfCourse = {
//    //
//    //        id: parseInt(retireId, retireId)
//    //        courseStatus: document.getElementById('CourseStatus').value
//    //
//    //    }
//    
//    
//    
//        console.log("Retiring course");
//    
//        await fetch(`api/RetireCourse/${retireId}`, {
//        //await fetch(`api/RetireCourse/${statusOfCourse}`, {
    //    
//            method: 'PUT',
//            headers: {
//      //    
//                //'Accept': 'application/json',
//                'Content-Type': 'application/json'
//      //    
//            },
//            body: JSON.stringify(statusOfCourse)
    //    
//        });
//    
//        console.log("Course retired.");
//    
//    }





















//    async function RetireSelectedCourse(retireId) {//retireId
//    
//        console.log(retireId);
//    
//        //const statusOfCourse = document.getElementById('CourseStatus'.value);
//    
//        const newStatusOfCourse = {
//    //
//            id: parseInt(retireId, retireId)
//    //        courseStatus: document.getElementById('CourseStatus').value
//    //
//        }
//    
//        console.log("Retiring course");
//    
//        await fetch(`api/RetireCourse/${newStatusOfCourse}`, {
//        //await fetch(`api/RetireCourse/${statusOfCourse}`, {
    //    
//            method: 'PUT',
//            headers: {
//      //    
//                //'Accept': 'application/json',
//                'Content-Type': 'application/json'
//      //    
//            },
//            body: JSON.stringify()
    //    
//        });
//    
//        console.log("Course retired.");
//    
//    }





















//    async function RetireSelectedCourse(retireId) {//retireId
//    
//        //const statusOfCourse = document.getElementById('CourseStatus'.value);
//    
//    //    const newStatusOfCourse = {
//    //
//    //        id: parseInt(statusOfCourse, 10),
//    //        courseStatus: document.getElementById('CourseStatus').value
//    //
//    //    }
//    
//        console.log("Retiring course");
//    
//        await fetch(`api/RetireCourse/${retireId}`, {
//        //await fetch(`api/RetireCourse/${statusOfCourse}`, {
    //    
//            method: 'PUT',
//            headers: {
        //    
//                //'Accept': 'application/json',
//                'Content-Type': 'application/json'
        //    
//            },
//            body: JSON.stringify()
    //    
//        });
//    
//        console.log("Course retired.");
//    
//    }




















//        async function RetireSelectedCourse(retireId) {//retireId
//        
//          console.log("Preparing to retire course...");
//      
//            const statusOfCourse = retireId;
//        
//            const newStatusOfCourse = {
//        
//                Id: retireId,
//                CourseStatus: false,
//      
//                CourseTitle: "",
//              CourseDescription: "",
//              CourseNumber: "",
//              CourseLength: "",
//              CourseDifficulty: "",
//              
//              UserId: ""
//        
//            }
//        
//            console.log("Retiring course");
//        
//            await fetch(`api/RetireCourse/${newStatusOfCourse}`, {
//            //await fetch(`api/RetireCourse/${statusOfCourse}`, {
//      //    
//                method: 'PUT',
//                headers: {
//          //    
//                    //'Accept': 'application/json',
//                    'Content-Type': 'application/json'
//          //    
//                },
//                body: JSON.stringify(newStatusOfCourse)
//      //    
//            });
//        
//            console.log("Course retired.");
//        
//        }
















async function RetireSelectedCourse(retireId) {//retireId
  
    console.log("Retiring course");

      const newStatusOfCourse = {
  
        Id: retireId//,
        //CourseStatus: false,

        //CourseTitle: "",
        //CourseDescription: "",
        //CourseNumber: "",
        //CourseLength: "",
        //CourseDifficulty: "",
        
        //UserId: ""
  
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
//      .then(() => ShowingAllCourses())

















//      //    api/AddCourseToUserProfile/{user}/{course}
//      
//      //     + `/` + {toThisUser} + `/` + {addThisCourse}
//      
//      async function AddingCourseToUser(toThisUser, addThisCourse) {
//      
//          console.log("Preparing to add course to user");
//      
//          const thisUser = {
//      
//              Id: toThisUser
//      
//          }
//      
//          const thisCourse = {
//      
//              Id: addThisCourse
//      
//          }
//      
//          await fetch(`api/AddCourseToUserProfile/${toThisUser}/${addThisCourse}`, 
//          { method: 'PUT',
//          headers: { 'Content-Type': 'application/json' },
//          body: JSON.stringify(thisUser, thisCourse)});
//      
//          console.log("Course assigned.");
//      
//      }
































async function AddingCourseToUser(toThisUser, addThisCourse) {

    console.log("Preparing to add course to user");

//    const thisUser = {
//
//        Id: toThisUser
//
//    }

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


































//    async function PleaseAddIt() {
//    
//        //const data = { courseName: 'example' };
//    
//        const newCourseTitle = document.getElementById('CourseTitle');
//        const newCourseDescription = document.getElementById('CourseDescription');
//        const newCourseNumber = document.getElementById('CourseNumber');
//        const newCourseLength = document.getElementById('CourseLength');
//        const newCourseDifficulty = document.getElementById('CourseDifficulty');
//        const newCourseStatus = document.getElementById('CourseStatus');
//    
//        const newCourse = {
    //    
//            CourseTitle: document.getElementById('CourseTitle'),
//            CourseDescription: newCourseDescription,
//            CourseNumber: newCourseNumber,
//            CourseLength: newCourseLength,
//            CourseDifficulty: newCourseDifficulty,
//            //CourseStatus: newCourseStatus
//            CourseStatus: true
//            
//        };
//    
//    fetch('api/AddCourse', {
//      method: 'POST', // or 'PUT'
//      headers: {
//        'Content-Type': 'application/json',
//      },
//      body: JSON.stringify(newCourse),
//    })
//    .then((response) => response.json())
//    //.then((newCourse) => {
//    //  console.log('Success:', newCourse);
//    //})
//    //.catch((error) => {
//    //  console.error('Error:', error);
//    //});
//    ;
//    }





























//    //  /api/AddCourse
//    async function AddThisCourse(bCourseTitle, bCourseDescription, bCourseNumber, bCourseLength, bCourseDifficulty, bCourseStatus) {



/////////////////////////////////////////////////////////////////////////////////////////
//              Det nedan fungerar som POST
/////////////////////////////////////////////////////////////////////////////////////////
//    
//    
//    
//        const newCourse = {
//    
//            CourseTitle: bCourseTitle,
//            CourseDescription: bCourseDescription,
//            CourseNumber: bCourseNumber,
//            CourseLength: bCourseLength,
//            CourseDifficulty: bCourseDifficulty,
//            //CourseStatus: bCourseStatus
//            CourseStatus: true,
//            UserId: ""
//            
//        };
//    
//    
//    
//    
//    //    const newCourseTitle = document.getElementById('bCourseTitle').value;
//    //    const newCourseDescription = document.getElementById('bCourseDescription').value;
//    //    const newCourseNumber = document.getElementById('bCourseNumber').value;
//    //    const newCourseLength = document.getElementById('bCourseLength').value;
//    //    const newCourseDifficulty = document.getElementById('bCourseDifficulty').value;
//    //    const newCourseStatus = document.getElementById('bCourseStatus').value;
//    
//    //    const newCourse = {
//    //
//    //        CourseTitle: newCourseTitle,
//    //        CourseDescription: newCourseDescription,
//    //        CourseNumber: newCourseNumber,
//    //        CourseLength: newCourseLength,
//    //        CourseDifficulty: newCourseDifficulty,
//    //        //CourseStatus: newCourseStatus
//    //        CourseStatus: true,
//    //        UserId: ""
//    //        
//    //    };
//    
//        await fetch(`api/AddCourse`, 
//        {method: 'POST', headers: {
//    //        'Accept': 'application/json',
//            'Content-Type': 'application/json'
//            },
//            body: JSON.stringify(newCourse)
//        });
//    }





























/*async function loadIntoTable(url, table) {

    const tableHead = table.querySelector("thead");
    const tableBody = table.querySelector("tbody");

    const response = await;

}

loadIntoTable("api/getallcourses", document.querySelector("myTestTable"));*/