function(e) {
   var previsualizationElements = document.querySelectorAll('.gs_r, .gs_or, .gs_scl');
   var paginator = document.querySelector("#gs_n");
   var paginatorItem = paginator.querySelectorAll('center > table > tbody > tr > td')

   let previsualizationHtml = [];
   let paginatorItemHtml = [];

   for (let i = 0; i < previsualizationElements.length; i++) {
      previsualizationHtml.push(previsualizationElements[i].outerHTML);
   }

   for (let i = 0; i < paginatorItem.length; i++) {
      paginatorItemHtml.push(paginatorItem[i].outerHTML);
   };

   const response = {
      previsualizationHtml,
      paginatorItemHtml
   };

   return JSON.stringify(response);
}