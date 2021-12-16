create table qianyg_课程  (
   qyg_课程编号  char(20)  PRIMARY  KEY,
   qyg_课程名称  char(20)  NOT  NULL,
   qyg_开课学期  char(20)  NOT  NULL,
   qyg_学时  int  NOT  NULL,
   qyg_课程类型  char(8)  NOT  NULL,
   qyg_学分  float  NOT  NULL
   )
