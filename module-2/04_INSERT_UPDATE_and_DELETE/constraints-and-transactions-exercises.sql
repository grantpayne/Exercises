-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor (first_name, last_name)
VALUES ('Hampton', 'Avenue')
INSERT INTO actor (first_name, last_name)
VALUES ('Lisa', 'Byway')

SELECT *
FROM actor

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
INSERT INTO film (title, description, release_year, language_id, original_language_id, rental_duration, rental_rate, length, replacement_cost, rating)
VALUES ('Euclidian PI', 'The epic story of Euclid as a pizza delivery boy in ancient Greece', 2008, 1, 1, 2, 4, 198, 19.99, null)

SELECT *
FROM film
WHERE title = 'Euclidian PI'

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
INSERT INTO film_actor (actor_id, film_id)
VALUES (201, 1001)
INSERT INTO film_actor (actor_id, film_id)
VALUES (202, 1001)

SELECT *
FROM film_actor
WHERE film_id = 1001

-- 4. Add Mathmagical to the category table.
INSERT INTO category (name)
VALUES ('Mathmagical')

SELECT *
FROM category

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
INSERT INTO film_category (film_id, category_id)
VALUES (1001, 17)

UPDATE film_category
SET category_id = 17
WHERE film_id IN (274, 494, 714, 996)

SELECT *
FROM film_category
WHERE film_id IN (274, 494, 714, 996, 1001)

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
WHERE film_id IN
(SELECT film_id
FROM film_category
WHERE category_id = 17)

SELECT *
FROM film
WHERE film_id IN
(SELECT film_id
FROM film_category
WHERE category_id = 17)

-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory (film_id, store_id)
VALUES (1001, 1)

INSERT INTO inventory (film_id, store_id)
VALUES (1001, 2)

SELECT *
FROM inventory
WHERE film_id = 1001

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE
FROM film
WHERE film_id = 1001
--Did not succeed due to foreign key existing within the film_actor table.
--The DELETE statement conflicted with the REFERENCE constraint "FK__film_acto__film___47DBAE45". The conflict occurred in database "dvdstore", table "dbo.film_actor", column 'film_id'.

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE
FROM category
WHERE category_id = 17
--Did not succeed due to foreign key existing within the film_category table.
--The DELETE statement conflicted with the REFERENCE constraint "FK__film_cate__categ__49C3F6B7". The conflict occurred in database "dvdstore", table "dbo.film_category", column 'category_id'.

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- <YOUR ANSWER HERE>
SELECT *
FROM film_category
WHERE category_id = 17
--succeeded because this row/table does not have any foreign keys pointing to it.

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- <YOUR ANSWER HERE>
DELETE
FROM category
WHERE category_id = 17
--Did not succeed due to films still existing with the 'Mathmagical' category assigned to them.  These films would need to be deleted or reassigned to a different category before deleting the category.

DELETE
FROM film
WHERE film_id = 1001
--Still does not succeed due to persisting reference conflicts resulting from the film_id foreign key

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--In order to delete the film from the film table, all key conflicts would need to be resolved.  This would include removing the film from the inventory, film_actor, and actor tables