export class Publication
{
    constructor(
        public id: number,
        public rentalObjectId: number,
        public fromDate: Date,
        public toDate?: Date)
    {
    }
}