create table qianyg_学生登入  (
   qyg_学号  CHAR(12)  PRIMARY  KEY,
   qyg_密码  CHAR(20)  NOT  NULL,
   constraint  FK_学号_学生登入  foreign  key  (qyg_学号) references qianyg_学生    
   )
