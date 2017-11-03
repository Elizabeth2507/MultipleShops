    var loadCount = 1;
    //var skipCount = ; // start at 6th record (assumes first 5 included in initial view)
    var takeCount = 3; // return new 5 records
    var hasMoreRecords = true;

 $(document).ready(function () {
     LoadProductFromServer();
         $(window).scroll(function () {
                if ($(window).scrollTop() == $(document).height() - $(window).height()) {
                    LoadProductFromServer();
                }
            });
 });

    function LoadProductFromServer() {
        if (!hasMoreRecords) {
            return;
        }
        
        $.ajax({
            
            url: '@Url.Action("Index")',
            data: { 'skipCount': loadCount * takeCount, },
            datatype: 'html',
            success: function (data) {
                if (data === null) {
                    hasMoreRecords = false; // signal no more records to display
                } else {
                    for (var i = 0; i < data.length; i++)
                    {
                        $("#result").append(data);
                        kipCount += takeCount; // update for next iteration
                    }
                    loadCount = loadCount + 1;
                    
                }
                
              
                
            },
            error: function () {
                alert("error");
            }
        });
        
        
    
    }

   
