# InfosetPizza
Asp.net core 5 ile geliştirildi


sorgulama yapılacak endpoint :


    api/branch/getfive
örnek sorgu :


    api/Branch/GetFive?latitude=38.549224&longitude=43.339409
    
    
örnek çıktı :



[
  {
    "id": 107,
    "name": "çayır şubesi",
    "latitude": 38.548237,
    "longitude": 43.338187,
    "distance": 0.152760506962777
  },
  {
    "id": 105,
    "name": "seyhan şubesi",
    "latitude": 38.55118,
    "longitude": 43.340826,
    "distance": 0.24996654810757646
  }
]
