create view qianyg_学生所学课程(学号,课程编号,课程名称,教师编号,教师名字,学期,课程类型)
as
select  qianyg_学生.qyg_学号,qianyg_课程.qyg_课程编号,qianyg_课程.qyg_课程名称,
          qianyg_教师.qyg_教师编号,qianyg_教师.qyg_姓名,
          qianyg_选课情况.qyg_学期,qianyg_课程.qyg_课程类型
  from qianyg_选课情况,qianyg_课程,qianyg_教师,qianyg_学生
  where qianyg_学生.qyg_班级编号=qianyg_选课情况.qyg_班级编号
        and qianyg_选课情况.qyg_课程编号=qianyg_课程.qyg_课程编号
        and qianyg_选课情况.qyg_教师编号=qianyg_教师.qyg_教师编号
