// Define Student class
class Student {
    constructor(studentData) {
        this.name = studentData.name;
        this.age = studentData.age;
        this.address = studentData.address;
        this.departments = studentData.departments;
    }

    // Method to get departments list
    getDepartmentsList() {
        if (this.departments && this.departments.length > 0) {
            return this.departments.map(department => `<li>${department}</li>`).join('');
        } else {
            return '<li>Not Enrolled in Any Department</li>';
        }
    }
}

// Define StudentCard class
class StudentCard {
    constructor(student) {
        this.student = student;
    }

    // Method to create student card
    createCard() {
        const studentDiv = document.createElement('article');
        studentDiv.classList.add('student');

        // Create and append elements for student details
        studentDiv.innerHTML = `
            <h2>${this.student.name}</h2>
            <p><strong>Age:</strong> ${this.student.age}</p>
            <p><strong>Address:</strong> ${this.student.address}</p>
            <p class="departments"><strong>Departments:</strong></p>
            <ul class="departments">
                ${this.student.getDepartmentsList()}
            </ul>
        `;

        return studentDiv;
    }
}

// Fetch data from the API
fetch('http://localhost:5235/api/StudentWithDepartment/withDepartments')
    .then(response => response.json())
    .then(data => {
        // Iterate over each student object
        data.forEach(studentData => {
            // Create Student instance
            const student = new Student(studentData);

            // Create StudentCard instance
            const studentCard = new StudentCard(student);

            // Append the student card to the container
            document.getElementById('students-container').appendChild(studentCard.createCard());
        });
    })
    .catch(error => {
        console.error('Error fetching data:', error);
    });