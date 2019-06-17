CREATE TABLE products (
  id INT PRIMARY KEY AUTO_INCREMENT);
  
CREATE TABLE categories (
  id INT PRIMARY KEY AUTO_INCREMENT);
  
CREATE TABLE prod_cat (
  prod_id INT,
  cat_id  INT);
  
ALTER TABLE prod_cat ADD FOREIGN KEY (prod_id) REFERENCES products(id);
ALTER TABLE prod_cat ADD FOREIGN KEY (cat_id) REFERENCES categories(id);



# Test values

INSERT INTO products   (id) VALUES (1), (2), (3);
INSERT INTO categories (id) VALUES (1), (2), (3);
INSERT INTO prod_cat (prod_id, cat_id) VALUES (1,3), (2,3), (1,1);


# Requested Select query


SELECT 
  products.id as prod_id,
  prod_cat.cat_id as cat_id
FROM 
  products LEFT JOIN prod_cat ON products.id=prod_cat.prod_id;
