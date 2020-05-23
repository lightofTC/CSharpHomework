xquery version "1.0";
for $b in doc('XQuery.xml')//person
where $b/dname
return $b
