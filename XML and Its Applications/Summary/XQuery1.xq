xquery version "1.0";
for $b in doc('XQuery.xml')//person
where $b/gender="male" and $b/age>=20
return $b 