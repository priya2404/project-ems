select * from Participant
select count(*) from Participant  order by eventid desc

select count(eventid) from Participant where useremailid= (select count(max((useremailid))) from Participant);


select eventid, count(useremailid) as maximum from dbo.Participant
group by eventid


select eventid where max(useremailid) from participant