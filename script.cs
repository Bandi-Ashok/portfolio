/* Basic layout */
body {
    font-family: Arial, sans-serif;
    background-color: #f4f4f4;
    color: #333;
}

/* Header */
header {
    background-color: #333;
    color: white;
    padding: 20px 0;
    text-align: center;
}

header h1 {
    font-size: 36px;
    margin-bottom: 10px;
}

header p {
    font-size: 18px;
    font-weight: lighter;
}

/* Sections */
section {
    padding: 50px 0;
}

.container {
    width: 80%;
    margin: 0 auto;
}

/* About Section */
#about h2 {
    font-size: 30px;
    margin-bottom: 20px;
}

#about p {
    font-size: 18px;
    line-height: 1.5;
}

/* Skills Section */
#skills h2 {
    font-size: 30px;
    margin-bottom: 20px;
}

#skills ul {
    list-style-type: none;
    padding: 0;
}

#skills li {
    font-size: 18px;
    margin-bottom: 10px;
}

/* Projects Section */
#projects h2 {
    font-size: 30px;
    margin-bottom: 30px;
}

.project {
    display: flex;
    margin-bottom: 30px;
}

.project img {
    width: 200px;
    height: 150px;
    object-fit: cover;
    margin-right: 20px;
}

.project-info h3 {
    font-size: 24px;
    margin-bottom: 10px;
}

.project-info p {
    font-size: 16px;
    color: #555;
}

/* Contact Section */
#contact h2 {
    font-size: 30px;
    margin-bottom: 20px;
}

form input, form textarea {
    width: 100%;
    padding: 10px;
    margin: 10px 0;
    border: 1px solid #ccc;
    border-radius: 5px;
}

form button {
    background-color: #333;
    color: white;
    padding: 10px 20px;
    border: none;
    cursor: pointer;
    border-radius: 5px;
}

form button:hover {
    background-color: #555;
}

/* Footer */
footer {
    background-color: #333;
    color: white;
    text-align: center;
    padding: 10px 0;
    margin-top: 50px;
}

footer p a {
    color: white;
    text-decoration: none;
}

footer p a:hover {
    text-decoration: underline;
}
