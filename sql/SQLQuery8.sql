create table qianyg_��ʦ����  (
   qyg_��ʦ���  CHAR(20)  PRIMARY  KEY,
   qyg_����  CHAR(20)  NOT  NULL,
   constraint  FK_��ʦ���_��ʦ����  foreign  key  (qyg_��ʦ���) references qianyg_��ʦ    
   )
