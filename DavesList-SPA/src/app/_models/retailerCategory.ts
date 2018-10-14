export interface RetailerCategory {
    id: number;
    categoryId: number;
    retailerId: number;
    // retailer props
    name: string;
    location: string;
    website: string;
    details: string;
    photo: string;
    // category props
    categoryName: string;
}
