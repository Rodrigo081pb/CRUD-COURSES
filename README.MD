
# CRUD-ENDPOINT-CURSOS

## Português

Este projeto é uma API RESTful desenvolvida em ASP.NET Core para gerenciar cursos e alunos, permitindo operações de CRUD (Criar, Ler, Atualizar, Deletar) para ambas as entidades.

### Funcionalidades

- **Cursos**
	- Criar curso
	- Listar todos os cursos
	- Buscar curso por ID
	- Atualizar curso
	- Deletar curso

- **Alunos**
	- Criar aluno
	- Listar todos os alunos
	- Buscar aluno por ID
	- Atualizar aluno
	- Remover aluno
	- Alterar curso do aluno
	- Listar alunos por curso

### Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core (com SQL Server)
- Swagger para documentação dos endpoints

### Como Executar

1. Configure a string de conexão com o banco de dados em `appsettings.json`.
2. Execute o projeto com o comando:
	 ```
	 dotnet run
	 ```
3. Acesse a documentação Swagger em `http://localhost:<porta>/swagger`.

---

## English

This project is a RESTful API built with ASP.NET Core to manage courses and students, providing CRUD (Create, Read, Update, Delete) operations for both entities.

### Features

- **Courses**
	- Create course
	- List all courses
	- Get course by ID
	- Update course
	- Delete course

- **Students**
	- Create student
	- List all students
	- Get student by ID
	- Update student
	- Remove student
	- Change student's course
	- List students by course

### Technologies Used

- ASP.NET Core
- Entity Framework Core (with SQL Server)
- Swagger for endpoint documentation

### How to Run

1. Set up your database connection string in `appsettings.json`.
2. Run the project with:
	 ```
	 dotnet run
	 ```
3. Access Swagger documentation at `http://localhost:<port>/swagger`.
