SELECT p.name, c.name from relations r
LEFT JOIN categories c on r.cat_id = c.id
LEFT JOIN products p on r.prod_id = p.id
ORDER BY p.id


