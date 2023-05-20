Create database test
CREATE TABLE book (
  serial_number int identity(1,1) PRIMARY KEY,
  title VARCHAR(255),
  publisher_name VARCHAR(255),
  publisher_age INT,
  page_no INT,
  publish_date DATE,
  publish_type VARCHAR(50)
);
INSERT INTO book (title, publisher_name, publisher_age, page_no, publish_date, publish_type)
VALUES ('The Great Gatsby', 'Scribner', 40, 218, '2022-01-15', 'Hardcover');

INSERT INTO book (title, publisher_name, publisher_age, page_no, publish_date, publish_type)
VALUES ('To Kill a Mockingbird', 'HarperCollins', 45, 281, '2021-07-20', 'Paperback');

INSERT INTO book (title, publisher_name, publisher_age, page_no, publish_date, publish_type)
VALUES ('1984', 'Penguin Books', 55, 328, '2020-11-10', 'E-book');

select *from book;
