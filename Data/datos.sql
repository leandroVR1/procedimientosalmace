-- Crear la tabla
CREATE TABLE Users (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(50),
    Email VARCHAR(100)
);

-- Procedimiento para leer usuarios (Read)
DELIMITER //
CREATE PROCEDURE GetUsers()
BEGIN
    SELECT * FROM Users;
END //
DELIMITER ;

-- Procedimiento para insertar usuario (Create)
DELIMITER //
CREATE PROCEDURE InsertUser(
    IN p_Name VARCHAR(50),
    IN p_Email VARCHAR(100)
)
BEGIN
    INSERT INTO Users (Name, Email)
    VALUES (p_Name, p_Email);
END //
DELIMITER ;

-- Procedimiento para actualizar usuario (Update)
DELIMITER //
CREATE PROCEDURE UpdateUser(
    IN p_Id INT,
    IN p_Name VARCHAR(50),
    IN p_Email VARCHAR(100)
)
BEGIN
    UPDATE Users
    SET Name = p_Name, Email = p_Email
    WHERE Id = p_Id;
END //
DELIMITER ;

-- Procedimiento para eliminar usuario (Delete)
DELIMITER //
CREATE PROCEDURE DeleteUser(
    IN p_Id INT
)
BEGIN
    DELETE FROM Users
    WHERE Id = p_Id;
END //
DELIMITER ;
