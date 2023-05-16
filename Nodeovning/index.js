const mongodb = require('mongodb')

async function main(){
    const client = new mongodb.MongoClient("mongodb://localhost")
    await client.connect()


    const db = client.db("BooksDB")

    const dbBooks = await db.collection("Books").find()

    await dbBooks.forEach(b => {
        console.log(b);
    })

}

main()