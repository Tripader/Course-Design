create table qianyg_教师登入  (
   qyg_教师编号  CHAR(20)  PRIMARY  KEY,
   qyg_密码  CHAR(20)  NOT  NULL,
   constraint  FK_教师编号_教师登入  foreign  key  (qyg_教师编号) references qianyg_教师    
   )
