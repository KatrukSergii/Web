
export class PublicationRequest
{
    constructor(
        public requestDate: Date,
        public publicationId: number,
        public fromDate?: Date,
        public dateTime?: Date,
        public contactEmail?: string,
        public contactPhone?: string)
    {
    }
}